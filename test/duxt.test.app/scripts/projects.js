import { projectCard } from "./projectCard.js";
import GitHubAPI from "./githubAPI.js";

const webHookGitHubPinned = "082fdd41-3be3-47ce-b0d2-42da13d71cf9";
const webHookGitHubLogin = "3c455d7a-89c1-4521-9c6a-9bd4febd2c09";
const webHookGitHubLanguageLogin = "a099cc09-6dcb-4b8f-985e-0e83744504d8";
const realGitHubPinned = "SeferMirza";
const realGitHubLogin = "SeferMirza";

export default async function Projects() {
  const result = [];
  const pinnedRepositories = await GitHubAPI.getPinnedRepositories(webHookGitHubPinned);

  const Repositories = await GitHubAPI.getUserRepositories(webHookGitHubLogin);

  for (const repository of Repositories) {
    if (pinnedRepositories.includes(repository.name)) {
      const languages = await GitHubAPI.getUserRepositoryLanguage(webHookGitHubLanguageLogin, repository.name);
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
