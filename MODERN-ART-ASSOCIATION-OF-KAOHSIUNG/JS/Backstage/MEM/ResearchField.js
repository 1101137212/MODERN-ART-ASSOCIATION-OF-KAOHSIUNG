$(document).ready(function () {
    $.ajax({
        url: '/BMEM/GetResearchFielddata_B',
        type: 'POST',
        dataType: 'json',
        success: function (data) {
            console.log(data);
        },
        error: function () {
            console.log("無法取得db");
        }
    });
    //$.ajax({
    //    url: '/BMEM/CreateResearchFielddata_B',
    //    type: 'POST',
    //    data: {
    //        ResearchField_Name: 'test'
    //    },
    //    dataType: 'json',
    //    success: function (data) {
    //        console.log("test");
    //    },
    //    error: function () {
    //        console.log("無法取得db");
    //    }
    //});
    //$.ajax({
    //    url: '/BMEM/UpdateResearchFielddata_B',
    //    type: 'POST',
    //    data: {
    //        ResearchField_Name: 'test111',
    //        ResearchField_ID: 31
    //    },
    //    dataType: 'json',
    //    success: function (data) {
    //        console.log("test");
    //    },
    //    error: function () {
    //        console.log("無法取得db");
    //    }
    //});
    //$.ajax({
    //    url: '/BMEM/DeleteResearchFielddata_B',
    //    type: 'POST',
    //    data: {
    //        ResearchField_ID: 31
    //    },
    //    dataType: 'json',
    //    success: function (data) {
    //        console.log("test");
    //    },
    //    error: function () {
    //        console.log("無法取得db");
    //    }
    //});
});