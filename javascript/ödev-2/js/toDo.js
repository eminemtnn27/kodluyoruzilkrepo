let list=document.getElementById('list');
let items=document.getElementsByTagName("li");
let close = document.getElementsByClassName("close"); 


function newElement(){
    let öge=document.createElement("span");
    let kaldir = document.createTextNode("x");
    let inputTxt=document.getElementById('task').value;
    let li=document.createElement("li");
    let text=document.createTextNode(inputTxt);
    li.appendChild(text);
    if (inputTxt === "") { //boş girdi olursa
        $(".error").toast("show");
      } else {
        $(".success").toast("show");
        document.getElementById("list").appendChild(li);
      }
      document.getElementById("task").value = "";
    
    öge.className="close";
    öge.appendChild(kaldir);
    li.appendChild(öge)

    for(var i=0; i<close.length;i++)
    {
        close[i].onclick = function () {
            var div = this.parentElement;
            div.style.display = "none";
            };
    }// x e tıklandığında ögeyi kaldırır
   
    }
 