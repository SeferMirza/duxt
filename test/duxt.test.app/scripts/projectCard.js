export function projectCard({name, language, url}) {
  const card = document.createElement("div");
  card.className = "card";

  const title = document.createElement("h1");
  title.className = "card-title";
  title.innerText = name;

  const cardContent = document.createElement("div");
  cardContent.className = "card-content-container";

  const contentTitle = document.createElement("h4");
  contentTitle.innerText = language;

  const btn = document.createElement("a");
  btn.className = "btn";
  btn.innerText = "Learn More";
  btn.href = url;

  cardContent.appendChild(contentTitle);
  cardContent.appendChild(btn);

  card.appendChild(title);
  card.appendChild(cardContent);

  return card;
}
