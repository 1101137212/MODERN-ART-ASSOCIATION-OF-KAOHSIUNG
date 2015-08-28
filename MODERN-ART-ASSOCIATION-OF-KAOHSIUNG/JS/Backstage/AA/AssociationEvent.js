$(document).ready(function () {
    $.ajax({
        url: '/BAA/GetAssociationEventdata_B',
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
    //    url: '/BAA/CreateAssociationEventdata_B',
    //    type: 'POST',
    //    data: {
    //        AssociationEvent_Title: 'test888',
    //        AssociationEvent_Detail: 'test888',
    //        AssociationEvent_Date: '2015/08/28',
    //        AssociationEvent_Picture: 'test',
    //        AssociationEvent_Modifier: 5,
    //        AssociationEvent_Modificationdatetime:'2015/08/28'
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
    //    url: '/BAA/UpdateAssociationEventdata_B',
    //    type: 'POST',
    //    data: {
    //        AssociationEvent_Title: 'test123',
    //        AssociationEvent_Detail: 'test234',
    //        AssociationEvent_Date: '2015/08/27',
    //        AssociationEvent_Picture: 'test',
    //        AssociationEvent_Modifier: 4,
    //        AssociationEvent_Modificationdatetime:'2015/08/27',
    //        AssociationEvent_ID: 11
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
    //    url: '/BAA/DeleteAssociationEventdata_B',
    //    type: 'POST',
    //    data: {
    //        AssociationEvent_ID: 12
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