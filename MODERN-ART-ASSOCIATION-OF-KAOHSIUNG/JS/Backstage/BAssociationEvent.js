$(document).ready(function () {
    $.ajax({
        url: '/BAA/GetAssociationEventdata',
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
    //    url: '/BAA/CreateAssociationEventdata',
    //    type: 'POST',
    //    data: {
    //        AssociationEvent_Title: 'test1',
    //        AssociationEvent_Detail: 'test2',
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
    //    url: '/BAA/UpdateAssociationEventdata',
    //    type: 'POST',
    //    data: {
    //        AssociationEvent_Title: 'test123',
    //        AssociationEvent_Detail: 'test234',
    //        AssociationEvent_Date: '2015/08/27',
    //        AssociationEvent_Picture: 'test',
    //        AssociationEvent_Modifier: 4,
    //        AssociationEvent_Modificationdatetime:'2015/08/27',
    //        AssociationEvent_ID: 6
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
    //    url: '/BAA/DeleteAssociationEventdata',
    //    type: 'POST',
    //    data: {
    //        AssociationEvent_ID: 7
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