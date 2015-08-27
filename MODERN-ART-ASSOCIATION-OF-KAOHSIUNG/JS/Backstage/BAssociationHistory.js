$(document).ready(function () {
    $.ajax({
        url: '/BAA/GetAssociationHistory',
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
    //    url: '/BAA/CreateAssociationHistorydata',
    //    type: 'POST',
    //    data: {
    //        AssociationHistory_Detail: 'test1',
    //        AssociationHistory_Detail2: 'test2',
    //        AssociationHistory_Detail3: 'test3',
    //        AssociationHistory_Modifier: 5,
    //        AssociationHistory_Modificationdatetime: '2015/08/26'
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
    //    url: '/BAA/UpdateAssociationHistorydata',
    //    type: 'POST',
    //    data: {
    //        AssociationHistory_Detail: 'test123',
    //        AssociationHistory_Detail2: 'test234',
    //        AssociationHistory_Detail3: 'test345',
    //        AssociationHistory_Modifier: 6,
    //        AssociationHistory_Modificationdatetime: '2015/08/26',
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
    //$.ajax({
    //    url: '/BAA/DeleteAssociationHistorydata',
    //    type: 'POST',
    //    data: {
    //        AssociationHistory_ID: 3
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