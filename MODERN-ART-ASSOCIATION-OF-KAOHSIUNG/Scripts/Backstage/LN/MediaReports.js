$(document).ready(function () {
    $.ajax({
        url: '/BLN/GetMediaReportsdata_B',
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
    //    url: '/BLN/CreateMediaReportsdata_B',
    //    type: 'POST',
    //    data: {
    //        MediaReports_Title: 'test333',
    //        MediaReports_Date: '2015/08/30',
    //        MediaReports_Detail: 'test333',
    //        MediaReports_Picture: 'test',
    //        MediaReports_Modifier: 5,
    //        MediaReports_Modificationdatetime: '2015/08/30'
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
    //    url: '/BLN/UpdateMediaReportsdata_B',
    //    type: 'POST',
    //    data: {
    //        MediaReports_Title: 'test333456',
    //        MediaReports_Date: '2015/08/3',
    //        MediaReports_Detail: 'test333456',
    //        MediaReports_Picture: 'test123',
    //        MediaReports_Modifier: 6,
    //        MediaReports_Modificationdatetime: '2015/08/3',
    //        MediaReports_ID: 3
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
    //    url: '/BLN/DeleteMediaReportsdata_B',
    //    type: 'POST',
    //    data: {
    //        MediaReports_ID: 5
    //    },
    //    dataType: 'json',
    //    success: function (data) {
    //        console.log("test");
    //    },
    //    error: function () {
    //        console.log("無法取得db");
    //    }
    //});
})