
async function makeGet(url) {
    const response = await fetch(url);
    const results = await response.json();

    return results;
}

async function makePost(url, data) {
    const response = await fetch(url, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
    });

    const result = await response.json();

    return result;
}


function makePut(config, onSuccess, onError) {
    $.ajax({
        url: config.url,
        type: "PUT",
        data: config.data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            onSuccess(data);
        },
        error: function (xhr, status, error) {
            onError(xhr, status, error);
        }
    });
}
