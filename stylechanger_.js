
/*Cookies: Orginally made by w3schools.com*/
/*Created by theKDL for Re-Volt Live, KDL_Tests*/


//set cookie
function setCookie(c_name,value,expiredays)
{
var exdate=new Date();
exdate.setDate(exdate.getDate()+expiredays);
document.cookie=c_name+ "=" +escape(value)+
((expiredays==null) ? "" : ";expires="+exdate.toGMTString());
}

//get cookie
function getCookie(c_name)
{
if (document.cookie.length>0)
  {
  c_start=document.cookie.indexOf(c_name + "=");
  if (c_start!=-1)
    {
    c_start=c_start + c_name.length+1;
    c_end=document.cookie.indexOf(";",c_start);
    if (c_end==-1) c_end=document.cookie.length;
    return unescape(document.cookie.substring(c_start,c_end));
    }
  }
return "";
}

/*My work, licensed under GNU GPL*/

var allthemes=9;


function Activ(n,comp)
{

	//get theme link?
	var Theme;
	var thname;
	n=Math.ceil(n);
	
	
	n=n+Math.ceil(comp);


if (n == 0)  n = allthemes;
if (n == allthemes + 1)  n = 1;

	
  switch(n) {

	case 1:	
	Theme= "http://revoltlive.zzl.org/new/ifreloaded.css";
	thname="I.F Reloaded (by IF&amp;KDL)";
	break;

	case 2:	
	Theme= "http://revoltlive.zzl.org/new/revora.css";
	thname="Revora (by Nero)";
	break;
	
	case 3:	
	Theme= "http://revoltlive.zzl.org/new/zip.css";
	thname="Zipperrulez's";
	break;
	
	case 4:	
	Theme= "http://revoltlive.zzl.org/new/glass.css";
	thname="BlackGlass (by KDL)";
	break;
	
	case 5:	
	Theme= "http://revoltlive.zzl.org/new/neo_revora.css";
	thname="Revora nuovo(by Nero)";
	break;
	
	case 6:	
	Theme= "http://revoltlive.zzl.org/new/modern.css";
	thname="Modern Times (by KDL)";
	break;
	
	case 7:	
	Theme= "http://revoltlive.zzl.org/new/BlueVolt.css";
	thname="BlueVolt (by KDL)";
	break;
	
		
		
	case 8:	
	Theme= "http://revoltlive.zzl.org/new/greentoy.css";
	thname="Green Toy (by KDL)";
	break;
	
	case 9:
	Theme = "http://revoltlive.zzl.org/new/invisionfree.css";
	thname ="Invision Free";
	break;
	
	
	
  }

 forbrowser(Theme)

 
  
setCookie("RVL_theme",n,90);
setCookie("RVL_theme_name",thname,90);

	

}
function forbrowser(str) {
var nav;
nav = '"' + navigator.userAgent + '"';
var score;
 score = nav.indexOf("Firefox") + nav.indexOf("Trident");

 
 
 if (score <0 )
 {
  document.write("<link rel=\"stylesheet\" type=\"text/css\" href=" + str + "></link");
} else {
       /* var st = document.getElementsByTagName("style");*/
       var sty = document.createElement("link");
       sty.setAttribute("rel","stylesheet");
       sty.setAttribute("type","text/css");
       sty.setAttribute("href",str);

     document.getElementsByTagName("head")[0].appendChild(sty);


 }
 
 
 
 //document.write("<link rel=\"stylesheet\" type=\"text/css\" href=" + Theme + "></link");
}

function doload()
{

    //avoid failure
    if (getCookie("RVL_theme") =="" || getCookie("RVL_theme")=="NaN") {
        setCookie("RVL_theme","1",90);
    }

    //oh, well, time to get started
    var theme = Math.ceil(getCookie("RVL_theme"));

    Activ(theme,0);
}

	