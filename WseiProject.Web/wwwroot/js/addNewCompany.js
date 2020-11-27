document.addEventListener("DOMContentLoaded", initializeEventListeners);

function initializeEventListeners() {
    const formElement = document.forms[0];
    formElement.addEventListener("submit", event => onFormSubmit(event));
}

function onFormSubmit(event) {
    event.preventDefault();
    addNewTree().then(() => console.log("Company added succesfully"));
}

async function addNewTree() {
    const URL = "http://localhost:56891/api/CompanyManagement";
    const company = getFormData()

    const response = await fetch(URL, {
        method: 'POST',
        body: JSON.stringify(company),
        headers: {
            'Content-Type': 'application/json'
        },
    })

    const responseJson = await response.json();

    if (responseJson.isSuccess) {
        onPostSuccess();
    }
}

function onPostSuccess() {
    const SUCCESS_BOX_SELECTOR = "#success-alert"
    const alertElement = document.querySelector(SUCCESS_BOX_SELECTOR);
    alertElement.style.display = "block";
}

function getFormData() {
    const form = document.forms[0];
    const keys = ["Name", "Description", "IsVisible"];
    return keys.reduce((obj, key, index) => {
        const value = form[index].type === "checkbox" ? form[index].checked : form[index].value;
        return { ...obj, [key]: value };
    }, {})
}