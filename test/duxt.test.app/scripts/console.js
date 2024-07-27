document.addEventListener('DOMContentLoaded', (event) => {
    const consoleElement = document.getElementById('console-text');
    const text = consoleElement.textContent;
    consoleElement.textContent = 'C:\\> ';
    let index = 0;
    const speed = 40;

    function typeWriter() {
        if (index < text.length) {
            // remove pipe
            consoleElement.textContent = consoleElement.textContent.slice(0, -1);
            // add next char and pipe
            consoleElement.textContent += `${text.charAt(index)}|`;
            index++;
            setTimeout(typeWriter, speed);
        }
    }

    typeWriter();
});
