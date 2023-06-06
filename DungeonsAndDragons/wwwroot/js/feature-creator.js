'use strict';

let num = 2;
const addButton = document.querySelector('#add-button');
const featureDiv = document.querySelector('#feature-1');
const featureList = document.querySelector('#feature-list');

addButton.addEventListener('click', () => {
   const dupe = featureDiv.cloneNode(true);
   const dupeRemoveButton = document.createElement("button");
   
   dupeRemoveButton.value = 'Remove';
   dupeRemoveButton.classList.add('btn');
   dupeRemoveButton.classList.add('btn-danger')
   dupeRemoveButton.id = `delete-button-${num-1}`;
   dupeRemoveButton.addEventListener('click', removeFeature(dupe));
   
   dupe.id = `feature-${num}`;
   dupe.prepend(dupeRemoveButton);
   
   num++;
   featureList.append(dupe);
});

function removeFeature(feature) {
    num--;
    feature.remove();
}