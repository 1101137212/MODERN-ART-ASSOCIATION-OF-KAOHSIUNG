$(document).ready(function () {
    $.ajax({
        url: '/BEX/GetExhibitionRecorddata_B',
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
    //    url: '/BEX/CreateExhibitionRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        ExhibitionRecord_State: 0,
    //        Member_ID: 4,
    //        Exhibition_ID: 2
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
    //    url: '/BEX/UpdateExhibitionRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        ExhibitionRecord_State: 1,
    //        Member_ID: 5,
    //        Exhibition_ID: 3,
    //        ExhibitionRecord_ID: 43
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
    //    url: '/BEX/DeleteExhibitionRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        ExhibitionRecord_ID: 43
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