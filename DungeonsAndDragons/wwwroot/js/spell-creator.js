'use strict';

const materialContainer = document.querySelector('#material-container');
const materialToggle = document.querySelector('#material');
const materialWriter = document.querySelector('#casting-materials');

materialToggle.addEventListener('change', () => {
    materialContainer.classList.toggle('d-none');
    materialWriter.toggleAttribute('required');
});
