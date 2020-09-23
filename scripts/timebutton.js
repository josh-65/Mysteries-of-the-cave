function timeDone(){
    var show = document.getElementById("show");
    show.style.visibility = "visible";
    var hide = document.getElementById("hide")
    hide.style.visibility = "hidden"
    };

setInterval(timeDone, 8000);