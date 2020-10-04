$(document).ready(function(){

    $("#buttonDelete").click(function(){

        $.ajax({
            type: "DELETE",
            url: "api/environment/9",
            datatype: "json",
            contentType: "application / json; charset = utf-8",
          })
          .done(function(data) {
            alert(data);
          })
          .fail(function() {
            alert( "error" );
          })
    })

    $("#buttonPost").click(function(){

      alert("teste");
      var obj = { id: 1};
  
      var myJSON = JSON.stringify(obj);

      $.ajax({
          type: "POST",
          url: "api/environment",
          datatype: "json",
          data: myJSON,
          contentType: "application / json; charset = utf-8",
        })
        .done(function(data) {
          alert(data);
        })
        .fail(function() {
          alert( "error" );
        })
  })
});
