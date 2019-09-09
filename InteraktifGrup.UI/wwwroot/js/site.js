function getRequest(url) {
    var result = null;
    
    $.ajax({
        contentType: 'application/json',
        data: JSON.stringify({
            userName: "bulut",
            password: "123"
        }),
        dataType: 'json',
        success: function (data) {
            result = data;
        },
        error: function (data, statu) {
            result = null;
        },
        async: false,
        type: 'POST',
        url: url
    });

    return result;
}

function postRequest(url, bodyName, body) {
    var result = null;
    var complexObject = {
        "aut": { "userName": "bulut", "password": "123" },
        "product": body
    };
    var bodyRequest = JSON.stringify(complexObject);
    $.ajax({
        contentType: 'application/json',
        data: bodyRequest,
        dataType: 'json',
        success: function (data) {
            result = data;
        },
        error: function (data, statu) {
            result = null;
        },
        async: false,
        type: 'POST',
        url: url
    });

    return result;
}


function loadCategoryOptions() {
    var select = document.getElementById("productCategory");
    if (select !== null) {
        var data = getRequest('https://localhost:44358/api/category/getlist');
        for (var item in data) {
            var option = document.createElement("option");
            option.value = data[item].categoryId;
            option.text = data[item].categoryName;
            select.appendChild(option);
        }
    }
}

function addButtonClick() {
    var categoryId = document.getElementById("productCategory").value;
    var name = document.getElementById("productName").value;
    var price = document.getElementById("productPrice").value;
    var body = {
        "CategoryId": categoryId,
        "ProductName": name,
        "Price": price
    };
    var result = postRequest('https://localhost:44358/api/product/add', "", body);
    if (result.status.code == 100) {
        alert("ekleme işlemi başarılı")
    }
}

function addRow(categoryName, productName, price) {

    var productTab = document.getElementById('productListTable');

    var rowCnt = productTab.rows.length;
    var tr = productTab.insertRow(rowCnt);
    tr = productTab.insertRow(rowCnt);

    var td = document.createElement('td');
    td = tr.insertCell(0);
    var button = document.createElement('input');

    button.setAttribute('type', 'button');
    button.setAttribute('value', 'Remove');

    button.setAttribute('onclick', 'removeRow(this)');
    td.appendChild(button);

    var td1 = document.createElement('td');
    td1 = tr.insertCell(1);
    var ele1 = document.createElement('input');
    ele1.setAttribute('type', 'text');
    ele1.setAttribute('value', categoryName);
    td1.appendChild(ele1);

    var td2 = document.createElement('td');
    td2 = tr.insertCell(2);
    var ele2 = document.createElement('input');
    ele2.setAttribute('type', 'text');
    ele2.setAttribute('value', productName);
    td2.appendChild(ele2);

    var td3 = document.createElement('td');
    td3 = tr.insertCell(3);
    var ele3 = document.createElement('input');
    ele3.setAttribute('type', 'text');
    ele3.setAttribute('value', price);
    td3.appendChild(ele3);
}

function removeRow() {

}

function loadProductList() {
    var table = document.getElementById('productListTable');
    if (table !== null) {
        var data = getRequest('https://localhost:44358/api/product/getlist');
        for (var item in data.productList) {

            addRow(data.productList[item].categoryName, data.productList[item].productName, data.productList[item].price);
        }
    }
}

function payment(isCart) {
    var payByCart = false;
    if (isCart === 'true') {
        payByCart = true;
    }
    $.ajax({
        success: function (data) {
            alert(data);
        },
        error: function (data, statu) {
            alert("başarısız!");
        },
        async: false,
        type: 'GET',
        url: 'https://localhost:44358/api/payment?isPaymentByCart=' + payByCart
    }); 
}

$(document).ready(function () {
    loadCategoryOptions();
    loadProductList();
});