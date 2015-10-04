$(document).ready(function () {
    $.ajax({
        url: '/BAA/GetAssociationHistorydata_B',
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
    //    url: '/BAA/CreateAssociationHistorydata_B',
    //    type: 'POST',
    //    data: {
    //        AssociationHistory_Detail: 'test11111',
    //        AssociationHistory_Modifier: 6,
    //        AssociationHistory_Modificationdatetime: '2015/08/30'
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
    //    url: '/BAA/UpdateAssociationHistorydata_B',
    //    type: 'POST',
    //    data: {
    //        AssociationHistory_Detail: 'test123',
    //        AssociationHistory_Modifier: 7,
    //        AssociationHistory_Modificationdatetime: '2015/08/26',
    //        AssociationHistory_ID: 4
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
    //    url: '/BAA/DeleteAssociationHistorydata_B',
    //    type: 'POST',
    //    data: {
    //        AssociationHistory_ID: 2
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