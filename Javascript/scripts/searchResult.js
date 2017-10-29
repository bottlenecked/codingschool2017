export default class SearchResult {
  constructor(result) {
    this.title = result.title;
    this.url = result.url;
    this.description = result.description;
  }

  render() {
    //NOTES:
    //1) in the real world we would have used a template engine (eg. mustache) or something beefier (angular)
    //2) we should have also html-escaped the values returned by the server to prevent xss and other such pains
    return `
    <div class="search-result mb-4">
      <h4 class="title"><a href="${this.url}" target=_blank>${this.title}</a></h4>
      <div class="url"><a href="${this.url}" target=_blank>${this.url}</a></div>
      <div class="description text-secondary">${this.description}</div>
    </div>
    `
  }
}