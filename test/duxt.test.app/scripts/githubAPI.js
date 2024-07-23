const gitHubWebhookBase = "https://webhook.site/";
const gitHubBase = "https://github.com/";
const gitHubAPIBase = "https://api.github.com/";
const debug = true;

async function getPinnedRepositories(login) {
  const result = [];

  const response = await fetch(`${debug ? gitHubWebhookBase : gitHubBase}${login}`,
    {
      headers: {
        "origin": "*"
      }
    }
  );
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

const gitHubAPIHeaders = {
  Accept: "application/vnd.github+json",
  "X-GitHub-Api-Version": "2022-11-28",
  "User-Agent":
    "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)",
};

async function getUserRepositories(login) {
  try {
    const response = await fetch(
      debug ? `${gitHubWebhookBase}${login}` : `${gitHubAPIBase}users/${login}/repos`,
      {
        headers: gitHubAPIHeaders,
        method: "GET"
      }
    );

    return await response.json();
  } catch (error) {
    console.error(`Error: ${error.message}`);
  }
}

async function getUserRepositoryLanguage(login, repositoryName) {
  try {
    const languages = await fetch(
      debug ? `${gitHubWebhookBase}${login}` : `${gitHubAPIBase}repos/${login}/${repositoryName}/languages`,
      {
        headers: gitHubAPIHeaders,
        method: "GET"
      }
    );

    return await languages.json();
  } catch (error) {
    console.error(`Error: ${error.message}`);
  }
}

const GitHubAPI = {
  getPinnedRepositories,
  getUserRepositories,
  getUserRepositoryLanguage,
};

export default GitHubAPI;
