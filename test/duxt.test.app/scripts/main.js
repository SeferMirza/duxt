import { proxyFetch } from "./proxyFetch.js";
import { projectCard } from "./projectCard.js";

async function getPinnedProjects(login) {
  const result = [];

  const response = await proxyFetch(`https://github.com/${login}`);
  if (!response.ok) {
    throw new Error(`HTTP error! Status: ${response.status}`);
  }

  const htmlContent = await response.text();
  const parser = new DOMParser();
  const doc = parser.parseFromString(htmlContent, "text/html");
  const olNode = doc.querySelector("ol");

  if (olNode) {
    const liNodes = olNode.querySelectorAll("li");
    liNodes.forEach((liNode) => {
      const spanNode = liNode.querySelector("span.repo");
      if (spanNode) {
        result.push(spanNode.textContent.trim());
      }
    });
  }

  return result;
}

async function main() {
  const result = [];
  const pinnedProjects = await getPinnedProjects("SeferMirza");

  const headers = {
    Accept: "application/vnd.github+json",
    "X-GitHub-Api-Version": "2022-11-28",
    "User-Agent":
      "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)",
  };

  console.log(
    "Sending request to https://api.github.com/users/sefermirza/repos"
  );

  try {
    const response = await fetch(
      "https://api.github.com/users/sefermirza/repos",
      { headers: headers }
    );

    if (response.ok) {
      const repositories = await response.json();

      for (const repository of repositories) {
        if (pinnedProjects.includes(repository.name)) {
          const languagesResponse = await fetch(
            `https://api.github.com/repos/SeferMirza/${repository.name}/languages`,
            { headers: headers }
          );
          const languages = await languagesResponse.json();
          const mainLanguage = Object.keys(languages)[0];
          result.push({
            name: repository.name,
            language: mainLanguage,
            url: repository.html_url,
          });
        }
      }

      const projects = document.createElement("div");
      projects.className = "projects";
      result.forEach((project) => {
        projects.appendChild(projectCard(project));
      });
      const projectList = document.getElementById("projects-container");
      projectList.appendChild(projects);
    }
  } catch (error) {
    console.error(`Error: ${error.message}`);
  }
}

main();
