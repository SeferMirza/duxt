import { projectCard } from "./projectCard.js";
import GitHubAPI from "./githubAPI.js";

export default async function Projects() {
  const result = [];
  const pinnedRepositories = await GitHubAPI.getPinnedRepositories("a0cbbe2f-d953-4c27-a362-e9f152f94c4f");

  const Repositories = await GitHubAPI.getUserRepositories("SeferMirza");

  for (const repository of Repositories) {
    if (pinnedRepositories.includes(repository.name)) {
      const languages = await GitHubAPI.getUserRepositoryLanguage("SeferMirza", repository.name);
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
