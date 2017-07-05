$(document).ready(function(){
    $("#vriendenNavBar").click(function(){
        $("#vriendschapverzoeken").animate({
            height: 'toggle'
        });
    });
});

function unhide(divID, otherDivId) {
var item = document.getElementById(divID);
if (item) {
item.className=(item.className=='hidden')?'unhidden':'hidden';
}
document.getElementById(otherDivId).className = 'hidden';
}
var old = '';
function update()

{
  var textarea = document.f.ta;
  var d = parent.dynamicframe.document; 
  if (old != textarea.value)
  {
    old = textarea.value;
    d.open();
    d.write(old);
    d.close();
  }
  window.setTimeout(update, 150);
}

$(document).ready(function(){
    $("#kruisje1").click(function(){
        $("#vriendnummer1").animate({
            height: 'toggle'
        });
		$("#vriendnummer2").animate({
			top: '80px'
		});
		$("#vriendnummer3").animate({
			top: '150px'
		});
		$("#newfriendsvalue").animate({
			toggle: 'hide'
		});
		
    });
	$("#vinkje1").click(function(){
        $("#vriendnummer1").animate({
            height: 'toggle'
        });
		$("#vriendnummer2").animate({
			top: '80px'
		});
		$("#vriendnummer3").animate({
			top: '150px'
		});
		$("#newfriendsvalue").animate({
			toggle: 'hide'
		});
		
    });
});

$(document).ready(function(){
    $("#kruisje2").click(function(){
        $("#vriendnummer2").animate({
            height: 'toggle'
        });
		$("#vriendnummer3").animate({
			top: '80px'
		});
    });
	$("#vinkje2").click(function(){
        $("#vriendnummer2").animate({
            height: 'toggle'
        });
		$("#vriendnummer3").animate({
			top: '80px'
		});
		$("#newfriendsvalue").animate({
			toggle: 'hide'
		});
    });
});
$(document).ready(function(){
    $("#minimizevrienden2").click(function(){
		$("#meldingendiv").animate({
			height: 'toggle'
		});
    });
});
$(document).ready(function(){
    $("#minimizevrienden").click(function(){
		$("#vriendschapverzoeken").animate({
			height: 'toggle'
		});
    });
});
$(document).ready(function(){
    $("#minimizemeldingen").click(function(){
		$("#meldingendiv").animate({
			height: 'toggle'
		});
    });
});

$(document).ready(function(){
    $("#meldingenbutton").click(function(){
		$("#meldingendiv").animate({
			height: 'toggle'
		});
		
    });
});

function meerlezenmelding(){
	alert("Coming soon!")
}

function addtxt(canvas) {
var obj=document.getElementById(canvas)
obj.value+="<p>Bewerk deze tekst<p>"
}

function addimg(canvas) {
var obj=document.getElementById(canvas)
obj.value+= "<img src=\"URL\"/>"
}

function addtable(canvas) {
var obj=document.getElementById(canvas)
obj.value+= "<style> table, th, td { border: 1px solid black; }</style><table><tr><td>nr1</td><td>nr2</td><td>nr3</td><tr><td>nr4</td><td>nr5</td><td>nr6</td><tr><td>nr7</td><td>nr8</td><td>nr9</td></table>"
}

function addlist(canvas) {
var obj=document.getElementById(canvas)
obj.value+= "<ol><li>Tekst nummer 1</li> <li>Tekst nummer 2</li> <li>Tekst nummer 3</li>"
}

function addlink(canvas) {
var obj=document.getElementById(canvas)
obj.value+= "<link href=\"URL\">Klik hier om naar de link te gaan!</link>"
}

function addtitel(canvas) {
var obj=document.getElementById(canvas)
obj.value+= "<h1>Hier de tekst</h1>"

}

function addvideo(canvas) {
var obj=document.getElementById(canvas)
obj.value+= "<iframe src=\"URL\"></iframe>"

}


function myFunction() {
			alert("Newbook\nWe hebben deze functie nog niet toegevoegd.");
		}