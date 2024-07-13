export async function proxyFetch(target) {
  const proxyUrl = "https://cors-anywhere.herokuapp.com/";
  const targetUrl = `${proxyUrl}${target}`;

  const headers = {
    Accept: "text/html",
    origin: "*",
  };

  const response = await fetch(targetUrl, {
    headers: headers,
  });

  return response;
}
