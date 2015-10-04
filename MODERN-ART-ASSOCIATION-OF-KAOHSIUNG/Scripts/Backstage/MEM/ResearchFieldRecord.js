$(document).ready(function () {
    $.ajax({
        url: '/BMEM/GetResearchFieldRecorddata_B',
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
    //    url: '/BMEM/CreateResearchFieldRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        ResearchFieldRecord_Date: '2015/10/04',
    //        Member_ID: 10,
    //        ResearchField_ID:1
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
    //    url: '/BMEM/UpdateResearchFieldRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        ResearchFieldRecord_Date: '2015/10/09',
    //        Member_ID: 7,
    //        ResearchField_ID:2,
    //        ResearchFieldRecord_ID: 37
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
    //    url: '/BMEM/DeleteResearchFieldRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        ResearchFieldRecord_ID: 37
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