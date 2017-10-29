import {Api} from "/scripts/api.js"
import SearchResult from "/scripts/searchResult.js"

//chrome ES6 bug: default export is mandatory


export default class View {
  constructor(view) {
    this.view = view;
  }

  initialize (){
    //setup listeners
    let button = this.view.getElementsByTagName("button")[0];
    attachSubmitHandler(button, view);
  }
}

function attachSubmitHandler(button, view) {
  button.addEventListener('click', e => {
    e.preventDefault();
    search(view);
  });
}

function search(view) {
  let textBox = view.querySelector("input[type=text]"),
      query = textBox.value;
  Api.search(query)
    .then(results => displayResults(results, view))
    .then(() => clearSearchText(textBox))
    .catch(error => showError(error, view))
}

function clearSearchText(textBox){
  textBox.value = '';
}

function displayResults(results, view) {
  let resultsSection = view.querySelector("#results");
  let html = results.reduce((html, result) => html + new SearchResult(result).render(), '');
  resultsSection.innerHTML = html;
}

function showError(error, view) {
  let resultsSection = view.querySelector("#results");
  let html = `
    <div class="alert alert-danger mt-3" role="alert">
      <h4>error ${error.error || error.message}</h4>
      No results available. Did you try searching for <strong>monkey</strong>?
    </div>
  `;
  resultsSection.innerHTML = html;
}




