'use strict';

const materialContainer = document.querySelector('#material-container');
const materialToggle = document.querySelector('#material');
const materialWriter = document.querySelector('#casting-materials');
    console.log("Here");

materialToggle.addEventListener('change', () => {
    console.log("Here");
    materialContainer.classList.toggle('d-none');
    materialWriter.toggleAttribute('required');
});
