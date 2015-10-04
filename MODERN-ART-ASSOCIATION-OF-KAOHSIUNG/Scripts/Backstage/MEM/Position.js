$(document).ready(function () {
    $.ajax({
        url: '/BMEM/GetPositiondata_B',
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
    //    url: '/BMEM/CreatePositiondata_B',
    //    type: 'POST',
    //    data: {
    //        Position_Name: 'test',
    //        Position_Competence: 1
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
    //    url: '/BMEM/UpdatePositiondata_B',
    //    type: 'POST',
    //    data: {
    //        Position_Name: 'test11',
    //        Position_Competence: '2',
    //        Position_ID: 17
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
    //    url: '/BMEM/DeletePositiondata_B',
    //    type: 'POST',
    //    data: {
    //        Position_ID: 17
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