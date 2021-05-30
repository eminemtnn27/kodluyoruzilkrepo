var myList=document.getElementsByTagName("LI");
var close = document.getElementsByClassName("close"); 
var list=document.getElementById('list');

function newElement(){
    var span=document.createElement("span");
    var kapat = document.createTextNode("x");
    var inputTxt=document.getElementById('task').value;
    var li=document.createElement("li");
    var t=document.createTextNode(inputTxt);
    li.appendChild(t);
    if (inputTxt === "") {
        $(".error").toast("show");
      } else {
        $(".success").toast("show");
        document.getElementById("list").appendChild(li);
      }
      document.getElementById("task").value = "";
    
    span.className="close";
    span.appendChild(kapat);
    li.appendChild(span)

    for(var i=0; i<close.length;i++)
    {
        close[i].onclick = function () {
            var div = this.parentElement;
            div.style.display = "none";
            };
    }
   
    }
 
 