async function getPinnedProjects(login) {
  const result = [];
  const proxyUrl = "https://cors-anywhere.herokuapp.com/";
  const targetUrl = `${proxyUrl}https://github.com/${login}`;

  const headers = {
    Accept: "text/html",
    origin: "*",
  };

  const response = await fetch(targetUrl, {
    headers: headers,
  });
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
            mainLanguage: mainLanguage,
            htmlUrl: repository.html_url,
          });
        }
      }

      const projects = document.createElement("div");
      projects.className = "projects";
      result.forEach((project) => {
        const card = document.createElement("div");
        card.className = "card";

        const title = document.createElement("h1");
        title.className = "card-title";
        title.innerText = project.name;

        const cardContent = document.createElement("div");
        cardContent.className = "card-content-container";

        const contentTitle = document.createElement("h4");
        contentTitle.innerText = project.mainLanguage;

        const btn = document.createElement("a");
        btn.className = "btn";
        btn.innerText = "Learn More";
        btn.href = project.htmlUrl;

        cardContent.appendChild(contentTitle);
        cardContent.appendChild(btn);

        card.appendChild(title);
        card.appendChild(cardContent);

        projects.appendChild(card);
      });
      const projectList = document.getElementById("projects-container");
      projectList.appendChild(projects);
    }
  } catch (error) {
    console.error(`Error: ${error.message}`);
  }
}

main();
