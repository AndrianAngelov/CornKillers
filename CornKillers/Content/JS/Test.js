/* File Created: август 21, 2014 */

function name() {
//    alert("")

    for (var i = 0; i < length; i++) {

    }
}

//$('.serialsPosters').click(){
//    function f
//}
$(document).ready(function () {
    $(".serialsPosters")
    .on( "mouseenter", function() {
        $(this).css({
            "color": "#fff",
            "background-color": "#282828",
            "font-weight": "bolder"
        });
    })
  .on( "mouseleave", function() {
      var styles = {
            Color: "#000",
            backgroundColor : "",
            fontWeight: ""
        };
    $( this ).css( styles );
    });
});