document.addEventListener("DOMContentLoaded", async () => {
  const terminal = document.getElementById("terminal");
  const input = document.getElementById("input");
  const label = document.getElementById("label");
  const history = document.getElementById("history");

  terminal.addEventListener("click", () => {
    input.focus();
  });

  input.addEventListener("keydown", async (event) => {
    if (event.key === "Enter") {
      event.preventDefault();
      if (input.value != "") {
        const inputValue = input.value;
        if (inputValue == "cls") {
          history.innerHTML = "";
          input.value = "";
          return;
        }
        const labelValue = label.textContent;
        history.innerHTML += `<br><span class="command">${labelValue} ${inputValue}</span><br>`;

        await fetch(`/${input.value}`)
          .then((response) => response.text())
          .then((content) => {
            history.innerHTML += content;
          })
          .catch((error) => {
            console.error(error);
            history.innerHTML += "Invalid command!<br>";
          });

        input.value = "";
      }
    }
  });
});
