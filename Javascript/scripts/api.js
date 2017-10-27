class Api {
  static search(query) {
    let opts = {
      headers: new Headers({'Cache-Control': 'no-cache'})
    };
    return fetch(`/search/${query}.json`, opts)
      .then(resp => {
        if(resp.status == 200){
          return resp.json();
        }
        throw {error: `${resp.status} ${resp.statusText}`};
      })
  }
}

export {Api}

export const alekos = 4;