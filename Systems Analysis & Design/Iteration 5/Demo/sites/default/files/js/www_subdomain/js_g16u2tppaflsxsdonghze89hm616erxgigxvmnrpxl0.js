/*!
	jQuery ColorBox v1.3.34 - 2013-02-04
	(c) 2013 Jack Moore - jacklmoore.com/colorbox
	license: http://www.opensource.org/licenses/mit-license.php
*/
(function(e,t,i){function o(i,o,n){var h=t.createElement(i);return o&&(h.id=V+o),n&&(h.style.cssText=n),e(h)}function n(e){var t=T.length,i=(N+e)%t;return 0>i?t+i:i}function h(e,t){return Math.round((/%/.test(e)?("x"===t?C.width():C.height())/100:1)*parseInt(e,10))}function r(e){return P.photo||P.photoRegex.test(e)}function l(e){return P.retinaUrl&&i.devicePixelRatio>1?e.replace(P.photoRegex,P.retinaSuffix):e}function s(){var t,i=e.data(B,J);null==i?(P=e.extend({},X),console&&console.log&&console.log("Error: cboxElement missing settings object")):P=e.extend({},i);for(t in P)e.isFunction(P[t])&&"on"!==t.slice(0,2)&&(P[t]=P[t].call(B));P.rel=P.rel||B.rel||e(B).data("rel")||"nofollow",P.href=P.href||e(B).attr("href"),P.title=P.title||B.title,"string"==typeof P.href&&(P.href=e.trim(P.href))}function a(i,o){e(t).trigger(i),st.trigger(i),e.isFunction(o)&&o.call(B)}function d(){var e,t,i,o,n,h=V+"Slideshow_",r="click."+V;P.slideshow&&T[1]?(t=function(){clearTimeout(e)},i=function(){(P.loop||T[N+1])&&(e=setTimeout($.next,P.slideshowSpeed))},o=function(){L.html(P.slideshowStop).unbind(r).one(r,n),st.bind(tt,i).bind(et,t).bind(it,n),m.removeClass(h+"off").addClass(h+"on")},n=function(){t(),st.unbind(tt,i).unbind(et,t).unbind(it,n),L.html(P.slideshowStart).unbind(r).one(r,function(){$.next(),o()}),m.removeClass(h+"on").addClass(h+"off")},P.slideshowAuto?o():n()):m.removeClass(h+"off "+h+"on")}function c(t){q||(B=t,s(),T=e(B),N=0,"nofollow"!==P.rel&&(T=e("."+Y).filter(function(){var t,i=e.data(this,J);return i&&(t=e(this).data("rel")||i.rel||this.rel),t===P.rel}),N=T.index(B),-1===N&&(T=T.add(B),N=T.length-1)),O||(O=j=!0,m.css({visibility:"hidden",display:"block"}),k=o(at,"LoadedContent","width:0; height:0; overflow:hidden").appendTo(g),_=x.height()+b.height()+g.outerHeight(!0)-g.height(),K=v.width()+y.width()+g.outerWidth(!0)-g.width(),z=k.outerHeight(!0),D=k.outerWidth(!0),P.returnFocus&&(e(B).blur(),st.one(ot,function(){e(B).focus()})),p.css({opacity:parseFloat(P.opacity),cursor:P.overlayClose?"pointer":"auto",visibility:"visible"}).show(),P.w=h(P.initialWidth,"x"),P.h=h(P.initialHeight,"y"),$.position(),rt&&C.bind("resize."+lt+" scroll."+lt,function(){p.css({width:C.width(),height:C.height(),top:C.scrollTop(),left:C.scrollLeft()})}).trigger("resize."+lt),d(),a(Z,P.onOpen),R.add(H).hide(),F.html(P.close).show()),$.load(!0))}function u(){!m&&t.body&&(Q=!1,C=e(i),m=o(at).attr({id:J,"class":ht?V+(rt?"IE6":"IE"):""}).hide(),p=o(at,"Overlay",rt?"position:absolute":"").hide(),W=o(at,"LoadingOverlay").add(o(at,"LoadingGraphic")),w=o(at,"Wrapper"),g=o(at,"Content").append(H=o(at,"Title"),E=o(at,"Current"),M=o(at,"Next"),S=o(at,"Previous"),L=o(at,"Slideshow"),F=o(at,"Close")),w.append(o(at).append(o(at,"TopLeft"),x=o(at,"TopCenter"),o(at,"TopRight")),o(at,!1,"clear:left").append(v=o(at,"MiddleLeft"),g,y=o(at,"MiddleRight")),o(at,!1,"clear:left").append(o(at,"BottomLeft"),b=o(at,"BottomCenter"),o(at,"BottomRight"))).find("div div").css({"float":"left"}),I=o(at,!1,"position:absolute; width:9999px; visibility:hidden; display:none"),R=M.add(S).add(E).add(L),e(t.body).append(p,m.append(w,I)))}function f(){function i(e){e.which>1||e.shiftKey||e.altKey||e.metaKey||(e.preventDefault(),c(this))}return m?(Q||(Q=!0,M.click(function(){$.next()}),S.click(function(){$.prev()}),F.click(function(){$.close()}),p.click(function(){P.overlayClose&&$.close()}),e(t).bind("keydown."+V,function(e){var t=e.keyCode;O&&P.escKey&&27===t&&(e.preventDefault(),$.close()),O&&P.arrowKey&&T[1]&&(37===t?(e.preventDefault(),S.click()):39===t&&(e.preventDefault(),M.click()))}),e.isFunction(e.fn.on)?e(t).on("click."+V,"."+Y,i):e("."+Y).live("click."+V,i)),!0):!1}var p,m,w,g,x,v,y,b,T,C,k,I,W,H,E,L,M,S,F,R,P,_,K,z,D,B,N,A,O,j,q,U,$,G,Q,X={transition:"elastic",speed:300,width:!1,initialWidth:"600",innerWidth:!1,maxWidth:!1,height:!1,initialHeight:"450",innerHeight:!1,maxHeight:!1,scalePhotos:!0,scrolling:!0,inline:!1,html:!1,iframe:!1,fastIframe:!0,photo:!1,href:!1,title:!1,rel:!1,opacity:.9,preloading:!0,className:!1,retinaImage:!1,retinaUrl:!1,retinaSuffix:"@2x.$1",current:"image {current} of {total}",previous:"previous",next:"next",close:"close",xhrError:"This content failed to load.",imgError:"This image failed to load.",open:!1,returnFocus:!0,reposition:!0,loop:!0,slideshow:!1,slideshowAuto:!0,slideshowSpeed:2500,slideshowStart:"start slideshow",slideshowStop:"stop slideshow",photoRegex:/\.(gif|png|jp(e|g|eg)|bmp|ico)((#|\?).*)?$/i,onOpen:!1,onLoad:!1,onComplete:!1,onCleanup:!1,onClosed:!1,overlayClose:!0,escKey:!0,arrowKey:!0,top:!1,bottom:!1,left:!1,right:!1,fixed:!1,data:void 0},J="colorbox",V="cbox",Y=V+"Element",Z=V+"_open",et=V+"_load",tt=V+"_complete",it=V+"_cleanup",ot=V+"_closed",nt=V+"_purge",ht=!e.support.leadingWhitespace,rt=ht&&!i.XMLHttpRequest,lt=V+"_IE6",st=e({}),at="div";e.colorbox||(e(u),$=e.fn[J]=e[J]=function(t,i){var o=this;if(t=t||{},u(),f()){if(e.isFunction(o))o=e("<a/>"),t.open=!0;else if(!o[0])return o;i&&(t.onComplete=i),o.each(function(){e.data(this,J,e.extend({},e.data(this,J)||X,t))}).addClass(Y),(e.isFunction(t.open)&&t.open.call(o)||t.open)&&c(o[0])}return o},$.position=function(e,t){function i(e){x[0].style.width=b[0].style.width=g[0].style.width=parseInt(e.style.width,10)-K+"px",g[0].style.height=v[0].style.height=y[0].style.height=parseInt(e.style.height,10)-_+"px"}var o,n,r,l=0,s=0,a=m.offset();C.unbind("resize."+V),m.css({top:-9e4,left:-9e4}),n=C.scrollTop(),r=C.scrollLeft(),P.fixed&&!rt?(a.top-=n,a.left-=r,m.css({position:"fixed"})):(l=n,s=r,m.css({position:"absolute"})),s+=P.right!==!1?Math.max(C.width()-P.w-D-K-h(P.right,"x"),0):P.left!==!1?h(P.left,"x"):Math.round(Math.max(C.width()-P.w-D-K,0)/2),l+=P.bottom!==!1?Math.max(C.height()-P.h-z-_-h(P.bottom,"y"),0):P.top!==!1?h(P.top,"y"):Math.round(Math.max(C.height()-P.h-z-_,0)/2),m.css({top:a.top,left:a.left,visibility:"visible"}),e=m.width()===P.w+D&&m.height()===P.h+z?0:e||0,w[0].style.width=w[0].style.height="9999px",o={width:P.w+D+K,height:P.h+z+_,top:l,left:s},0===e&&m.css(o),m.dequeue().animate(o,{duration:e,complete:function(){i(this),j=!1,w[0].style.width=P.w+D+K+"px",w[0].style.height=P.h+z+_+"px",P.reposition&&setTimeout(function(){C.bind("resize."+V,$.position)},1),t&&t()},step:function(){i(this)}})},$.resize=function(e){O&&(e=e||{},e.width&&(P.w=h(e.width,"x")-D-K),e.innerWidth&&(P.w=h(e.innerWidth,"x")),k.css({width:P.w}),e.height&&(P.h=h(e.height,"y")-z-_),e.innerHeight&&(P.h=h(e.innerHeight,"y")),e.innerHeight||e.height||(k.css({height:"auto"}),P.h=k.height()),k.css({height:P.h}),$.position("none"===P.transition?0:P.speed))},$.prep=function(t){function i(){return P.w=P.w||k.width(),P.w=P.mw&&P.mw<P.w?P.mw:P.w,P.w}function h(){return P.h=P.h||k.height(),P.h=P.mh&&P.mh<P.h?P.mh:P.h,P.h}if(O){var l,s="none"===P.transition?0:P.speed;k.empty().remove(),k=o(at,"LoadedContent").append(t),k.hide().appendTo(I.show()).css({width:i(),overflow:P.scrolling?"auto":"hidden"}).css({height:h()}).prependTo(g),I.hide(),e(A).css({"float":"none"}),l=function(){function t(){ht&&m[0].style.removeAttribute("filter")}var i,h,l=T.length,d="frameBorder",c="allowTransparency";O&&(h=function(){clearTimeout(U),W.remove(),a(tt,P.onComplete)},ht&&A&&k.fadeIn(100),H.html(P.title).add(k).show(),l>1?("string"==typeof P.current&&E.html(P.current.replace("{current}",N+1).replace("{total}",l)).show(),M[P.loop||l-1>N?"show":"hide"]().html(P.next),S[P.loop||N?"show":"hide"]().html(P.previous),P.slideshow&&L.show(),P.preloading&&e.each([n(-1),n(1)],function(){var t,i,o=T[this],n=e.data(o,J);n&&n.href?(t=n.href,e.isFunction(t)&&(t=t.call(o))):t=e(o).attr("href"),t&&(r(t)||n.photo)&&(i=new Image,i.src=t)})):R.hide(),P.iframe?(i=o("iframe")[0],d in i&&(i[d]=0),c in i&&(i[c]="true"),P.scrolling||(i.scrolling="no"),e(i).attr({src:P.href,name:(new Date).getTime(),"class":V+"Iframe",allowFullScreen:!0,webkitAllowFullScreen:!0,mozallowfullscreen:!0}).one("load",h).appendTo(k),st.one(nt,function(){i.src="//about:blank"}),P.fastIframe&&e(i).trigger("load")):h(),"fade"===P.transition?m.fadeTo(s,1,t):t())},"fade"===P.transition?m.fadeTo(s,0,function(){$.position(0,l)}):$.position(s,l)}},$.load=function(t){var n,d,c,u=$.prep;j=!0,A=!1,B=T[N],t||s(),G&&m.add(p).removeClass(G),P.className&&m.add(p).addClass(P.className),G=P.className,a(nt),a(et,P.onLoad),P.h=P.height?h(P.height,"y")-z-_:P.innerHeight&&h(P.innerHeight,"y"),P.w=P.width?h(P.width,"x")-D-K:P.innerWidth&&h(P.innerWidth,"x"),P.mw=P.w,P.mh=P.h,P.maxWidth&&(P.mw=h(P.maxWidth,"x")-D-K,P.mw=P.w&&P.w<P.mw?P.w:P.mw),P.maxHeight&&(P.mh=h(P.maxHeight,"y")-z-_,P.mh=P.h&&P.h<P.mh?P.h:P.mh),n=P.href,U=setTimeout(function(){W.appendTo(g)},100),P.inline?(c=o(at).hide().insertBefore(e(n)[0]),st.one(nt,function(){c.replaceWith(k.children())}),u(e(n))):P.iframe?u(" "):P.html?u(P.html):r(n)?(n=l(n),e(A=new Image).addClass(V+"Photo").bind("error",function(){P.title=!1,u(o(at,"Error").html(P.imgError))}).one("load",function(){var e;P.retinaImage&&i.devicePixelRatio>1&&(A.height=A.height/i.devicePixelRatio,A.width=A.width/i.devicePixelRatio),P.scalePhotos&&(d=function(){A.height-=A.height*e,A.width-=A.width*e},P.mw&&A.width>P.mw&&(e=(A.width-P.mw)/A.width,d()),P.mh&&A.height>P.mh&&(e=(A.height-P.mh)/A.height,d())),P.h&&(A.style.marginTop=Math.max(P.mh-A.height,0)/2+"px"),T[1]&&(P.loop||T[N+1])&&(A.style.cursor="pointer",A.onclick=function(){$.next()}),ht&&(A.style.msInterpolationMode="bicubic"),setTimeout(function(){u(A)},1)}),setTimeout(function(){A.src=n},1)):n&&I.load(n,P.data,function(t,i){u("error"===i?o(at,"Error").html(P.xhrError):e(this).contents())})},$.next=function(){!j&&T[1]&&(P.loop||T[N+1])&&(N=n(1),$.load())},$.prev=function(){!j&&T[1]&&(P.loop||N)&&(N=n(-1),$.load())},$.close=function(){O&&!q&&(q=!0,O=!1,a(it,P.onCleanup),C.unbind("."+V+" ."+lt),p.fadeTo(200,0),m.stop().fadeTo(300,0,function(){m.add(p).css({opacity:1,cursor:"auto"}).hide(),a(nt),k.empty().remove(),setTimeout(function(){q=!1,a(ot,P.onClosed)},1)}))},$.remove=function(){e([]).add(m).add(p).remove(),m=null,e("."+Y).removeData(J).removeClass(Y),e(t).unbind("click."+V)},$.element=function(){return e(B)},$.settings=X)})(jQuery,document,window);;
(function ($) {

Drupal.behaviors.initColorbox = {
  attach: function (context, settings) {
    if (!$.isFunction($.colorbox) || typeof settings.colorbox === 'undefined') {
      return;
    }

    if (settings.colorbox.mobiledetect && window.matchMedia) {
      // Disable Colorbox for small screens.
      var mq = window.matchMedia("(max-device-width: " + settings.colorbox.mobiledevicewidth + ")");
      if (mq.matches) {
        return;
      }
    }

    $('.colorbox', context)
      .once('init-colorbox')
      .colorbox(settings.colorbox);

    $(context).bind('cbox_complete', function () {
      Drupal.attachBehaviors('#cboxLoadedContent');
    });
  }
};

})(jQuery);
;
/*
 * jScrollPane - v2.0.0beta10 - 2011-04-17
 * http://jscrollpane.kelvinluck.com/
 *
 * Copyright (c) 2010 Kelvin Luck
 * Dual licensed under the MIT and GPL licenses.
 */
(function(b,a,c){b.fn.jScrollPane=function(f){function d(E,P){var aA,R=this,Z,al,w,an,U,aa,z,r,aB,aG,aw,j,J,i,k,ab,V,ar,Y,u,B,at,ag,ao,H,m,av,az,y,ax,aJ,g,M,ak=true,Q=true,aI=false,l=false,aq=E.clone(false,false).empty(),ad=b.fn.mwheelIntent?"mwheelIntent.jsp":"mousewheel.jsp";aJ=E.css("paddingTop")+" "+E.css("paddingRight")+" "+E.css("paddingBottom")+" "+E.css("paddingLeft");g=(parseInt(E.css("paddingLeft"),10)||0)+(parseInt(E.css("paddingRight"),10)||0);function au(aS){var aN,aP,aO,aL,aK,aR,aQ=false,aM=false;aA=aS;if(Z===c){aK=E.scrollTop();aR=E.scrollLeft();E.css({overflow:"hidden",padding:0});al=E.innerWidth()+g;w=E.innerHeight();E.width(al);Z=b('<div class="jspPane" />').css("padding",aJ).append(E.children());an=b('<div class="jspContainer" />').css({width:al+"px",height:w+"px"}).append(Z).appendTo(E)}else{E.css("width","");aQ=aA.stickToBottom&&L();aM=aA.stickToRight&&C();aL=E.innerWidth()+g!=al||E.outerHeight()!=w;if(aL){al=E.innerWidth()+g;w=E.innerHeight();an.css({width:al+"px",height:w+"px"})}if(!aL&&M==U&&Z.outerHeight()==aa){E.width(al);return}M=U;Z.css("width","");E.width(al);an.find(">.jspVerticalBar,>.jspHorizontalBar").remove().end()}Z.css("overflow","auto");if(aS.contentWidth){U=aS.contentWidth}else{U=Z[0].scrollWidth}aa=Z[0].scrollHeight;Z.css("overflow","");z=U/al;r=aa/w;aB=r>1;aG=z>1;if(!(aG||aB)){E.removeClass("jspScrollable");Z.css({top:0,width:an.width()-g});o();F();S();x();aj()}else{E.addClass("jspScrollable");aN=aA.maintainPosition&&(J||ab);if(aN){aP=aE();aO=aC()}aH();A();G();if(aN){O(aM?(U-al):aP,false);N(aQ?(aa-w):aO,false)}K();ah();ap();if(aA.enableKeyboardNavigation){T()}if(aA.clickOnTrack){q()}D();if(aA.hijackInternalLinks){n()}}if(aA.autoReinitialise&&!ax){ax=setInterval(function(){au(aA)},aA.autoReinitialiseDelay)}else{if(!aA.autoReinitialise&&ax){clearInterval(ax)}}aK&&E.scrollTop(0)&&N(aK,false);aR&&E.scrollLeft(0)&&O(aR,false);E.trigger("jsp-initialised",[aG||aB])}function aH(){if(aB){an.append(b('<div class="jspVerticalBar" />').append(b('<div class="jspCap jspCapTop" />'),b('<div class="jspTrack" />').append(b('<div class="jspDrag" />').append(b('<div class="jspDragTop" />'),b('<div class="jspDragBottom" />'))),b('<div class="jspCap jspCapBottom" />')));V=an.find(">.jspVerticalBar");ar=V.find(">.jspTrack");aw=ar.find(">.jspDrag");if(aA.showArrows){at=b('<a class="jspArrow jspArrowUp" />').bind("mousedown.jsp",aF(0,-1)).bind("click.jsp",aD);ag=b('<a class="jspArrow jspArrowDown" />').bind("mousedown.jsp",aF(0,1)).bind("click.jsp",aD);if(aA.arrowScrollOnHover){at.bind("mouseover.jsp",aF(0,-1,at));ag.bind("mouseover.jsp",aF(0,1,ag))}am(ar,aA.verticalArrowPositions,at,ag)}u=w;an.find(">.jspVerticalBar>.jspCap:visible,>.jspVerticalBar>.jspArrow").each(function(){u-=b(this).outerHeight()});aw.hover(function(){aw.addClass("jspHover")},function(){aw.removeClass("jspHover")}).bind("mousedown.jsp",function(aK){b("html").bind("dragstart.jsp selectstart.jsp",aD);aw.addClass("jspActive");var s=aK.pageY-aw.position().top;b("html").bind("mousemove.jsp",function(aL){W(aL.pageY-s,false)}).bind("mouseup.jsp mouseleave.jsp",ay);return false});p()}}function p(){ar.height(u+"px");J=0;Y=aA.verticalGutter+ar.outerWidth();Z.width(al-Y-g);try{if(V.position().left===0){Z.css("margin-left",Y+"px")}}catch(s){}}function A(){if(aG){an.append(b('<div class="jspHorizontalBar" />').append(b('<div class="jspCap jspCapLeft" />'),b('<div class="jspTrack" />').append(b('<div class="jspDrag" />').append(b('<div class="jspDragLeft" />'),b('<div class="jspDragRight" />'))),b('<div class="jspCap jspCapRight" />')));ao=an.find(">.jspHorizontalBar");H=ao.find(">.jspTrack");i=H.find(">.jspDrag");if(aA.showArrows){az=b('<a class="jspArrow jspArrowLeft" />').bind("mousedown.jsp",aF(-1,0)).bind("click.jsp",aD);y=b('<a class="jspArrow jspArrowRight" />').bind("mousedown.jsp",aF(1,0)).bind("click.jsp",aD);
if(aA.arrowScrollOnHover){az.bind("mouseover.jsp",aF(-1,0,az));y.bind("mouseover.jsp",aF(1,0,y))}am(H,aA.horizontalArrowPositions,az,y)}i.hover(function(){i.addClass("jspHover")},function(){i.removeClass("jspHover")}).bind("mousedown.jsp",function(aK){b("html").bind("dragstart.jsp selectstart.jsp",aD);i.addClass("jspActive");var s=aK.pageX-i.position().left;b("html").bind("mousemove.jsp",function(aL){X(aL.pageX-s,false)}).bind("mouseup.jsp mouseleave.jsp",ay);return false});m=an.innerWidth();ai()}}function ai(){an.find(">.jspHorizontalBar>.jspCap:visible,>.jspHorizontalBar>.jspArrow").each(function(){m-=b(this).outerWidth()});H.width(m+"px");ab=0}function G(){if(aG&&aB){var aK=H.outerHeight(),s=ar.outerWidth();u-=aK;b(ao).find(">.jspCap:visible,>.jspArrow").each(function(){m+=b(this).outerWidth()});m-=s;w-=s;al-=aK;H.parent().append(b('<div class="jspCorner" />').css("width",aK+"px"));p();ai()}if(aG){Z.width((an.outerWidth()-g)+"px")}aa=Z.outerHeight();r=aa/w;if(aG){av=Math.ceil(1/z*m);if(av>aA.horizontalDragMaxWidth){av=aA.horizontalDragMaxWidth}else{if(av<aA.horizontalDragMinWidth){av=aA.horizontalDragMinWidth}}i.width(av+"px");k=m-av;af(ab)}if(aB){B=Math.ceil(1/r*u);if(B>aA.verticalDragMaxHeight){B=aA.verticalDragMaxHeight}else{if(B<aA.verticalDragMinHeight){B=aA.verticalDragMinHeight}}aw.height(B+"px");j=u-B;ae(J)}}function am(aL,aN,aK,s){var aP="before",aM="after",aO;if(aN=="os"){aN=/Mac/.test(navigator.platform)?"after":"split"}if(aN==aP){aM=aN}else{if(aN==aM){aP=aN;aO=aK;aK=s;s=aO}}aL[aP](aK)[aM](s)}function aF(aK,s,aL){return function(){I(aK,s,this,aL);this.blur();return false}}function I(aN,aM,aQ,aP){aQ=b(aQ).addClass("jspActive");var aO,aL,aK=true,s=function(){if(aN!==0){R.scrollByX(aN*aA.arrowButtonSpeed)}if(aM!==0){R.scrollByY(aM*aA.arrowButtonSpeed)}aL=setTimeout(s,aK?aA.initialDelay:aA.arrowRepeatFreq);aK=false};s();aO=aP?"mouseout.jsp":"mouseup.jsp";aP=aP||b("html");aP.bind(aO,function(){aQ.removeClass("jspActive");aL&&clearTimeout(aL);aL=null;aP.unbind(aO)})}function q(){x();if(aB){ar.bind("mousedown.jsp",function(aP){if(aP.originalTarget===c||aP.originalTarget==aP.currentTarget){var aN=b(this),aQ=aN.offset(),aO=aP.pageY-aQ.top-J,aL,aK=true,s=function(){var aT=aN.offset(),aU=aP.pageY-aT.top-B/2,aR=w*aA.scrollPagePercent,aS=j*aR/(aa-w);if(aO<0){if(J-aS>aU){R.scrollByY(-aR)}else{W(aU)}}else{if(aO>0){if(J+aS<aU){R.scrollByY(aR)}else{W(aU)}}else{aM();return}}aL=setTimeout(s,aK?aA.initialDelay:aA.trackClickRepeatFreq);aK=false},aM=function(){aL&&clearTimeout(aL);aL=null;b(document).unbind("mouseup.jsp",aM)};s();b(document).bind("mouseup.jsp",aM);return false}})}if(aG){H.bind("mousedown.jsp",function(aP){if(aP.originalTarget===c||aP.originalTarget==aP.currentTarget){var aN=b(this),aQ=aN.offset(),aO=aP.pageX-aQ.left-ab,aL,aK=true,s=function(){var aT=aN.offset(),aU=aP.pageX-aT.left-av/2,aR=al*aA.scrollPagePercent,aS=k*aR/(U-al);if(aO<0){if(ab-aS>aU){R.scrollByX(-aR)}else{X(aU)}}else{if(aO>0){if(ab+aS<aU){R.scrollByX(aR)}else{X(aU)}}else{aM();return}}aL=setTimeout(s,aK?aA.initialDelay:aA.trackClickRepeatFreq);aK=false},aM=function(){aL&&clearTimeout(aL);aL=null;b(document).unbind("mouseup.jsp",aM)};s();b(document).bind("mouseup.jsp",aM);return false}})}}function x(){if(H){H.unbind("mousedown.jsp")}if(ar){ar.unbind("mousedown.jsp")}}function ay(){b("html").unbind("dragstart.jsp selectstart.jsp mousemove.jsp mouseup.jsp mouseleave.jsp");if(aw){aw.removeClass("jspActive")}if(i){i.removeClass("jspActive")}}function W(s,aK){if(!aB){return}if(s<0){s=0}else{if(s>j){s=j}}if(aK===c){aK=aA.animateScroll}if(aK){R.animate(aw,"top",s,ae)}else{aw.css("top",s);ae(s)}}function ae(aK){if(aK===c){aK=aw.position().top}an.scrollTop(0);J=aK;var aN=J===0,aL=J==j,aM=aK/j,s=-aM*(aa-w);if(ak!=aN||aI!=aL){ak=aN;aI=aL;E.trigger("jsp-arrow-change",[ak,aI,Q,l])}v(aN,aL);Z.css("top",s);E.trigger("jsp-scroll-y",[-s,aN,aL]).trigger("scroll")}function X(aK,s){if(!aG){return}if(aK<0){aK=0}else{if(aK>k){aK=k}}if(s===c){s=aA.animateScroll}if(s){R.animate(i,"left",aK,af)
}else{i.css("left",aK);af(aK)}}function af(aK){if(aK===c){aK=i.position().left}an.scrollTop(0);ab=aK;var aN=ab===0,aM=ab==k,aL=aK/k,s=-aL*(U-al);if(Q!=aN||l!=aM){Q=aN;l=aM;E.trigger("jsp-arrow-change",[ak,aI,Q,l])}t(aN,aM);Z.css("left",s);E.trigger("jsp-scroll-x",[-s,aN,aM]).trigger("scroll")}function v(aK,s){if(aA.showArrows){at[aK?"addClass":"removeClass"]("jspDisabled");ag[s?"addClass":"removeClass"]("jspDisabled")}}function t(aK,s){if(aA.showArrows){az[aK?"addClass":"removeClass"]("jspDisabled");y[s?"addClass":"removeClass"]("jspDisabled")}}function N(s,aK){var aL=s/(aa-w);W(aL*j,aK)}function O(aK,s){var aL=aK/(U-al);X(aL*k,s)}function ac(aX,aS,aL){var aP,aM,aN,s=0,aW=0,aK,aR,aQ,aU,aT,aV;try{aP=b(aX)}catch(aO){return}aM=aP.outerHeight();aN=aP.outerWidth();an.scrollTop(0);an.scrollLeft(0);while(!aP.is(".jspPane")){s+=aP.position().top;aW+=aP.position().left;aP=aP.offsetParent();if(/^body|html$/i.test(aP[0].nodeName)){return}}aK=aC();aQ=aK+w;if(s<aK||aS){aT=s-aA.verticalGutter}else{if(s+aM>aQ){aT=s-w+aM+aA.verticalGutter}}if(aT){N(aT,aL)}aR=aE();aU=aR+al;if(aW<aR||aS){aV=aW-aA.horizontalGutter}else{if(aW+aN>aU){aV=aW-al+aN+aA.horizontalGutter}}if(aV){O(aV,aL)}}function aE(){return -Z.position().left}function aC(){return -Z.position().top}function L(){var s=aa-w;return(s>20)&&(s-aC()<10)}function C(){var s=U-al;return(s>20)&&(s-aE()<10)}function ah(){an.unbind(ad).bind(ad,function(aN,aO,aM,aK){var aL=ab,s=J;R.scrollBy(aM*aA.mouseWheelSpeed,-aK*aA.mouseWheelSpeed,false);return aL==ab&&s==J})}function o(){an.unbind(ad)}function aD(){return false}function K(){Z.find(":input,a").unbind("focus.jsp").bind("focus.jsp",function(s){ac(s.target,false)})}function F(){Z.find(":input,a").unbind("focus.jsp")}function T(){var s,aK,aM=[];aG&&aM.push(ao[0]);aB&&aM.push(V[0]);Z.focus(function(){E.focus()});E.attr("tabindex",0).unbind("keydown.jsp keypress.jsp").bind("keydown.jsp",function(aP){if(aP.target!==this&&!(aM.length&&b(aP.target).closest(aM).length)){return}var aO=ab,aN=J;switch(aP.keyCode){case 40:case 38:case 34:case 32:case 33:case 39:case 37:s=aP.keyCode;aL();break;case 35:N(aa-w);s=null;break;case 36:N(0);s=null;break}aK=aP.keyCode==s&&aO!=ab||aN!=J;return !aK}).bind("keypress.jsp",function(aN){if(aN.keyCode==s){aL()}return !aK});if(aA.hideFocus){E.css("outline","none");if("hideFocus" in an[0]){E.attr("hideFocus",true)}}else{E.css("outline","");if("hideFocus" in an[0]){E.attr("hideFocus",false)}}function aL(){var aO=ab,aN=J;switch(s){case 40:R.scrollByY(aA.keyboardSpeed,false);break;case 38:R.scrollByY(-aA.keyboardSpeed,false);break;case 34:case 32:R.scrollByY(w*aA.scrollPagePercent,false);break;case 33:R.scrollByY(-w*aA.scrollPagePercent,false);break;case 39:R.scrollByX(aA.keyboardSpeed,false);break;case 37:R.scrollByX(-aA.keyboardSpeed,false);break}aK=aO!=ab||aN!=J;return aK}}function S(){E.attr("tabindex","-1").removeAttr("tabindex").unbind("keydown.jsp keypress.jsp")}function D(){if(location.hash&&location.hash.length>1){var aL,aK;try{aL=b(location.hash)}catch(s){return}if(aL.length&&Z.find(location.hash)){if(an.scrollTop()===0){aK=setInterval(function(){if(an.scrollTop()>0){ac(location.hash,true);b(document).scrollTop(an.position().top);clearInterval(aK)}},50)}else{ac(location.hash,true);b(document).scrollTop(an.position().top)}}}}function aj(){b("a.jspHijack").unbind("click.jsp-hijack").removeClass("jspHijack")}function n(){aj();b("a[href^=#]").addClass("jspHijack").bind("click.jsp-hijack",function(){var s=this.href.split("#"),aK;if(s.length>1){aK=s[1];if(aK.length>0&&Z.find("#"+aK).length>0){ac("#"+aK,true);return false}}})}function ap(){var aL,aK,aN,aM,aO,s=false;an.unbind("touchstart.jsp touchmove.jsp touchend.jsp click.jsp-touchclick").bind("touchstart.jsp",function(aP){var aQ=aP.originalEvent.touches[0];aL=aE();aK=aC();aN=aQ.pageX;aM=aQ.pageY;aO=false;s=true}).bind("touchmove.jsp",function(aS){if(!s){return}var aR=aS.originalEvent.touches[0],aQ=ab,aP=J;R.scrollTo(aL+aN-aR.pageX,aK+aM-aR.pageY);aO=aO||Math.abs(aN-aR.pageX)>5||Math.abs(aM-aR.pageY)>5;
return aQ==ab&&aP==J}).bind("touchend.jsp",function(aP){s=false}).bind("click.jsp-touchclick",function(aP){if(aO){aO=false;return false}})}function h(){var s=aC(),aK=aE();E.removeClass("jspScrollable").unbind(".jsp");E.replaceWith(aq.append(Z.children()));aq.scrollTop(s);aq.scrollLeft(aK)}b.extend(R,{reinitialise:function(aK){aK=b.extend({},aA,aK);au(aK)},scrollToElement:function(aL,aK,s){ac(aL,aK,s)},scrollTo:function(aL,s,aK){O(aL,aK);N(s,aK)},scrollToX:function(aK,s){O(aK,s)},scrollToY:function(s,aK){N(s,aK)},scrollToPercentX:function(aK,s){O(aK*(U-al),s)},scrollToPercentY:function(aK,s){N(aK*(aa-w),s)},scrollBy:function(aK,s,aL){R.scrollByX(aK,aL);R.scrollByY(s,aL)},scrollByX:function(s,aL){var aK=aE()+s,aM=aK/(U-al);X(aM*k,aL)},scrollByY:function(s,aL){var aK=aC()+s,aM=aK/(aa-w);W(aM*j,aL)},positionDragX:function(s,aK){X(s,aK)},positionDragY:function(aK,s){W(aK,s)},animate:function(aK,aN,s,aM){var aL={};aL[aN]=s;aK.animate(aL,{duration:aA.animateDuration,ease:aA.animateEase,queue:false,step:aM})},getContentPositionX:function(){return aE()},getContentPositionY:function(){return aC()},getContentWidth:function(){return U},getContentHeight:function(){return aa},getPercentScrolledX:function(){return aE()/(U-al)},getPercentScrolledY:function(){return aC()/(aa-w)},getIsScrollableH:function(){return aG},getIsScrollableV:function(){return aB},getContentPane:function(){return Z},scrollToBottom:function(s){W(j,s)},hijackInternalLinks:function(){n()},destroy:function(){h()}});au(P)}f=b.extend({},b.fn.jScrollPane.defaults,f);b.each(["mouseWheelSpeed","arrowButtonSpeed","trackClickSpeed","keyboardSpeed"],function(){f[this]=f[this]||f.speed});var e;this.each(function(){var g=b(this),h=g.data("jsp");if(h){h.reinitialise(f)}else{h=new d(g,f);g.data("jsp",h)}e=e?e.add(g):g});return e};b.fn.jScrollPane.defaults={showArrows:false,maintainPosition:true,stickToBottom:false,stickToRight:false,clickOnTrack:true,autoReinitialise:false,autoReinitialiseDelay:500,verticalDragMinHeight:0,verticalDragMaxHeight:99999,horizontalDragMinWidth:0,horizontalDragMaxWidth:99999,contentWidth:c,animateScroll:false,animateDuration:300,animateEase:"linear",hijackInternalLinks:false,verticalGutter:4,horizontalGutter:4,mouseWheelSpeed:0,arrowButtonSpeed:0,arrowRepeatFreq:50,arrowScrollOnHover:false,trackClickSpeed:0,trackClickRepeatFreq:70,verticalArrowPositions:"split",horizontalArrowPositions:"split",enableKeyboardNavigation:true,hideFocus:false,keyboardSpeed:0,initialDelay:300,speed:30,scrollPagePercent:0.8}})(jQuery,this);;
/*! Copyright (c) 2010 Brandon Aaron (http://brandonaaron.net)
 * Licensed under the MIT License (LICENSE.txt).
 *
 * Thanks to: http://adomas.org/javascript-mouse-wheel/ for some pointers.
 * Thanks to: Mathias Bank(http://www.mathias-bank.de) for a scope bug fix.
 * Thanks to: Seamus Leahy for adding deltaX and deltaY
 *
 * Version: 3.0.4
 * 
 * Requires: 1.2.2+
 */

(function($) {

var types = ['DOMMouseScroll', 'mousewheel'];

$.event.special.mousewheel = {
    setup: function() {
        if ( this.addEventListener ) {
            for ( var i=types.length; i; ) {
                this.addEventListener( types[--i], handler, false );
            }
        } else {
            this.onmousewheel = handler;
        }
    },
    
    teardown: function() {
        if ( this.removeEventListener ) {
            for ( var i=types.length; i; ) {
                this.removeEventListener( types[--i], handler, false );
            }
        } else {
            this.onmousewheel = null;
        }
    }
};

$.fn.extend({
    mousewheel: function(fn) {
        return fn ? this.bind("mousewheel", fn) : this.trigger("mousewheel");
    },
    
    unmousewheel: function(fn) {
        return this.unbind("mousewheel", fn);
    }
});


function handler(event) {
    var orgEvent = event || window.event, args = [].slice.call( arguments, 1 ), delta = 0, returnValue = true, deltaX = 0, deltaY = 0;
    event = $.event.fix(orgEvent);
    event.type = "mousewheel";
    
    // Old school scrollwheel delta
    if ( event.wheelDelta ) { delta = event.wheelDelta/120; }
    if ( event.detail     ) { delta = -event.detail/3; }
    
    // New school multidimensional scroll (touchpads) deltas
    deltaY = delta;
    
    // Gecko
    if ( orgEvent.axis !== undefined && orgEvent.axis === orgEvent.HORIZONTAL_AXIS ) {
        deltaY = 0;
        deltaX = -1*delta;
    }
    
    // Webkit
    if ( orgEvent.wheelDeltaY !== undefined ) { deltaY = orgEvent.wheelDeltaY/120; }
    if ( orgEvent.wheelDeltaX !== undefined ) { deltaX = -1*orgEvent.wheelDeltaX/120; }
    
    // Add event and delta to the front of the arguments
    args.unshift(event, delta, deltaX, deltaY);
    
    return $.event.handle.apply(this, args);
}

})(jQuery);;
(function ($) {

  Drupal.behaviors.jScrollPane = {
    attach: function (context, settings) {
      var jScrollPane = Drupal.settings.jScrollPane['class'];
      $(jScrollPane, context).jScrollPane();
    }
  };

})(jQuery);
;
(function($) {
  Drupal.behaviors.custom_search = {
    attach: function(context) {

      if (!Drupal.settings.custom_search.solr) {
        // Check if the search box is not empty on submit
        $('form.search-form', context).submit(function(){
          var $this = $(this);
          var box = $this.find('input.custom-search-box');
          if (box.val() != undefined && box.val() == '') {
            $this.find('input.custom-search-box').addClass('error');
            return false;
          }
          // If basic search is hidden, copy or value to the keys
          if ($this.find('#edit-keys').parents('div.element-invisible').attr('class') == 'element-invisible') {
            $this.find('#edit-keys').val($this.find('#edit-or').val());
            $this.find('#edit-or').val('');
          }
          return true;
        });
      }

      // Search from target
      $('form.search-form').attr('target', Drupal.settings.custom_search.form_target);

      // Displays Popup.
      $('form.search-form input.custom-search-box', context).bind('click focus', function(e){
        var $parentForm = $(this).parents('form');
        // check if there's something in the popup and displays it
        var popup = $parentForm.find('fieldset.custom_search-popup');
        if (popup.find('input,select').length && !popup.hasClass('opened')) {
          popup.fadeIn().addClass('opened');
        }
        e.stopPropagation();
      });
      $(document).bind('click focus', function(){
        $('fieldset.custom_search-popup').hide().removeClass('opened');
      });

      // Handle checkboxes
      $('.custom-search-selector input:checkbox', context).each(function(){
        var el = $(this);
        if (el.val() == 'c-all') {
          el.change(function(){
            $(this).parents('.custom-search-selector').find('input:checkbox[value!=c-all]').attr('checked', false);
          });
        }
        else {
          if (el.val().substr(0,2) == 'c-') {
            el.change(function(){
              $('.custom-search-selector input:checkbox').each(function(){
                if ($(this).val().substr(0,2) == 'o-') {
                  $(this).attr('checked', false);
                }
              });
              $(this).parents('.custom-search-selector').find('input:checkbox[value=c-all]').attr('checked', false);
            });
          } else {
            el.change(function(){
              $(this).parents('.custom-search-selector').find('input:checkbox[value!=' + el.val() + ']').attr('checked', false);
            });
          }
        }
      });

      // Handle popup.
      var popup = $('fieldset.custom_search-popup:not(.custom_search-processed)', context).addClass("custom_search-processed");
      popup.click(function(e){
        e.stopPropagation();
      })
      popup.append('<a class="custom_search-popup-close" href="#">' + Drupal.t('Close') + '</a>');
      $('a.custom_search-popup-close').click(function(e){
        $('fieldset.custom_search-popup.opened').hide().removeClass('opened');
        e.preventDefault();
      });

    }
  }
})(jQuery);
;
/**
 * @file
 * Some basic behaviors and utility functions for Views.
 */
(function ($) {

  Drupal.Views = {};

  /**
   * JQuery UI tabs, Views integration component.
   */
  Drupal.behaviors.viewsTabs = {
    attach: function (context) {
      if ($.viewsUi && $.viewsUi.tabs) {
        $('#views-tabset').once('views-processed').viewsTabs({
          selectedClass: 'active'
        });
      }

      $('a.views-remove-link').once('views-processed').click(function(event) {
        var id = $(this).attr('id').replace('views-remove-link-', '');
        $('#views-row-' + id).hide();
        $('#views-removed-' + id).attr('checked', true);
        event.preventDefault();
      });
      /**
    * Here is to handle display deletion
    * (checking in the hidden checkbox and hiding out the row).
    */
      $('a.display-remove-link')
        .addClass('display-processed')
        .click(function() {
          var id = $(this).attr('id').replace('display-remove-link-', '');
          $('#display-row-' + id).hide();
          $('#display-removed-' + id).attr('checked', true);
          return false;
        });
    }
  };

  /**
 * Helper function to parse a querystring.
 */
  Drupal.Views.parseQueryString = function (query) {
    var args = {};
    var pos = query.indexOf('?');
    if (pos != -1) {
      query = query.substring(pos + 1);
    }
    var pairs = query.split('&');
    for (var i in pairs) {
      if (typeof(pairs[i]) == 'string') {
        var pair = pairs[i].split('=');
        // Ignore the 'q' path argument, if present.
        if (pair[0] != 'q' && pair[1]) {
          args[decodeURIComponent(pair[0].replace(/\+/g, ' '))] = decodeURIComponent(pair[1].replace(/\+/g, ' '));
        }
      }
    }
    return args;
  };

  /**
 * Helper function to return a view's arguments based on a path.
 */
  Drupal.Views.parseViewArgs = function (href, viewPath) {

    // Provide language prefix.
    if (Drupal.settings.pathPrefix) {
      var viewPath = Drupal.settings.pathPrefix + viewPath;
    }
    var returnObj = {};
    var path = Drupal.Views.getPath(href);
    // Ensure we have a correct path.
    if (viewPath && path.substring(0, viewPath.length + 1) == viewPath + '/') {
      var args = decodeURIComponent(path.substring(viewPath.length + 1, path.length));
      returnObj.view_args = args;
      returnObj.view_path = path;
    }
    return returnObj;
  };

  /**
 * Strip off the protocol plus domain from an href.
 */
  Drupal.Views.pathPortion = function (href) {
    // Remove e.g. http://example.com if present.
    var protocol = window.location.protocol;
    if (href.substring(0, protocol.length) == protocol) {
      // 2 is the length of the '//' that normally follows the protocol.
      href = href.substring(href.indexOf('/', protocol.length + 2));
    }
    return href;
  };

  /**
 * Return the Drupal path portion of an href.
 */
  Drupal.Views.getPath = function (href) {
    href = Drupal.Views.pathPortion(href);
    href = href.substring(Drupal.settings.basePath.length, href.length);
    // 3 is the length of the '?q=' added to the url without clean urls.
    if (href.substring(0, 3) == '?q=') {
      href = href.substring(3, href.length);
    }
    var chars = ['#', '?', '&'];
    for (var i in chars) {
      if (href.indexOf(chars[i]) > -1) {
        href = href.substr(0, href.indexOf(chars[i]));
      }
    }
    return href;
  };

})(jQuery);
;
(function ($) {

/**
 * A progressbar object. Initialized with the given id. Must be inserted into
 * the DOM afterwards through progressBar.element.
 *
 * method is the function which will perform the HTTP request to get the
 * progress bar state. Either "GET" or "POST".
 *
 * e.g. pb = new progressBar('myProgressBar');
 *      some_element.appendChild(pb.element);
 */
Drupal.progressBar = function (id, updateCallback, method, errorCallback) {
  var pb = this;
  this.id = id;
  this.method = method || 'GET';
  this.updateCallback = updateCallback;
  this.errorCallback = errorCallback;

  // The WAI-ARIA setting aria-live="polite" will announce changes after users
  // have completed their current activity and not interrupt the screen reader.
  this.element = $('<div class="progress" aria-live="polite"></div>').attr('id', id);
  this.element.html('<div class="bar"><div class="filled"></div></div>' +
                    '<div class="percentage"></div>' +
                    '<div class="message">&nbsp;</div>');
};

/**
 * Set the percentage and status message for the progressbar.
 */
Drupal.progressBar.prototype.setProgress = function (percentage, message) {
  if (percentage >= 0 && percentage <= 100) {
    $('div.filled', this.element).css('width', percentage + '%');
    $('div.percentage', this.element).html(percentage + '%');
  }
  $('div.message', this.element).html(message);
  if (this.updateCallback) {
    this.updateCallback(percentage, message, this);
  }
};

/**
 * Start monitoring progress via Ajax.
 */
Drupal.progressBar.prototype.startMonitoring = function (uri, delay) {
  this.delay = delay;
  this.uri = uri;
  this.sendPing();
};

/**
 * Stop monitoring progress via Ajax.
 */
Drupal.progressBar.prototype.stopMonitoring = function () {
  clearTimeout(this.timer);
  // This allows monitoring to be stopped from within the callback.
  this.uri = null;
};

/**
 * Request progress data from server.
 */
Drupal.progressBar.prototype.sendPing = function () {
  if (this.timer) {
    clearTimeout(this.timer);
  }
  if (this.uri) {
    var pb = this;
    // When doing a post request, you need non-null data. Otherwise a
    // HTTP 411 or HTTP 406 (with Apache mod_security) error may result.
    $.ajax({
      type: this.method,
      url: this.uri,
      data: '',
      dataType: 'json',
      success: function (progress) {
        // Display errors.
        if (progress.status == 0) {
          pb.displayError(progress.data);
          return;
        }
        // Update display.
        pb.setProgress(progress.percentage, progress.message);
        // Schedule next timer.
        pb.timer = setTimeout(function () { pb.sendPing(); }, pb.delay);
      },
      error: function (xmlhttp) {
        pb.displayError(Drupal.ajaxError(xmlhttp, pb.uri));
      }
    });
  }
};

/**
 * Display errors on the page.
 */
Drupal.progressBar.prototype.displayError = function (string) {
  var error = $('<div class="messages error"></div>').html(string);
  $(this.element).before(error).hide();

  if (this.errorCallback) {
    this.errorCallback(this);
  }
};

})(jQuery);
;
/**
 * @file
 * Handles AJAX fetching of views, including filter submission and response.
 */
(function ($) {

  /**
   * Attaches the AJAX behavior to exposed filter forms and key views links.
   */
  Drupal.behaviors.ViewsAjaxView = {};
  Drupal.behaviors.ViewsAjaxView.attach = function() {
    if (Drupal.settings && Drupal.settings.views && Drupal.settings.views.ajaxViews) {
      $.each(Drupal.settings.views.ajaxViews, function(i, settings) {
        Drupal.views.instances[i] = new Drupal.views.ajaxView(settings);
      });
    }
  };

  Drupal.views = {};
  Drupal.views.instances = {};

  /**
   * JavaScript object for a certain view.
   */
  Drupal.views.ajaxView = function(settings) {
    var selector = '.view-dom-id-' + settings.view_dom_id;
    this.$view = $(selector);

    // Retrieve the path to use for views' ajax.
    var ajax_path = Drupal.settings.views.ajax_path;

    // If there are multiple views this might've ended up showing up multiple
    // times.
    if (ajax_path.constructor.toString().indexOf("Array") != -1) {
      ajax_path = ajax_path[0];
    }

    // Check if there are any GET parameters to send to views.
    var queryString = window.location.search || '';
    if (queryString !== '') {
      // Remove the question mark and Drupal path component if any.
      var queryString = queryString.slice(1).replace(/q=[^&]+&?|&?render=[^&]+/, '');
      if (queryString !== '') {
        // If there is a '?' in ajax_path, clean url are on and & should be
        // used to add parameters.
        queryString = ((/\?/.test(ajax_path)) ? '&' : '?') + queryString;
      }
    }

    this.element_settings = {
      url: ajax_path + queryString,
      submit: settings,
      setClick: true,
      event: 'click',
      selector: selector,
      progress: {
        type: 'throbber'
      }
    };

    this.settings = settings;

    // Add the ajax to exposed forms.
    this.$exposed_form = $('#views-exposed-form-' + settings.view_name.replace(/_/g, '-') + '-' + settings.view_display_id.replace(/_/g, '-'));
    this.$exposed_form.once(jQuery.proxy(this.attachExposedFormAjax, this));

    // Store Drupal.ajax objects here for all pager links.
    this.links = [];

    // Add the ajax to pagers.
    this.$view
      .once(jQuery.proxy(this.attachPagerAjax, this));

    // Add a trigger to update this view specifically. In order to trigger a
    // refresh use the following code.
    //
    // @code
    // jQuery('.view-name').trigger('RefreshView');
    // @endcode
    // Add a trigger to update this view specifically.
    var self_settings = this.element_settings;
    self_settings.event = 'RefreshView';
    var self = this;
    this.$view.once('refresh', function () {
      self.refreshViewAjax = new Drupal.ajax(self.selector, self.$view, self_settings);
    });
  };

  Drupal.views.ajaxView.prototype.attachExposedFormAjax = function() {
    var button = $('input[type=submit], button[type=submit], input[type=image]', this.$exposed_form);
    button = button[0];

    // Call the autocomplete submit before doing AJAX.
    $(button).click(function () {
      if (Drupal.autocompleteSubmit) {
        Drupal.autocompleteSubmit();
      }
    });

    this.exposedFormAjax = new Drupal.ajax($(button).attr('id'), button, this.element_settings);
  };

  /**
   * Attach the ajax behavior to each link.
   */
  Drupal.views.ajaxView.prototype.attachPagerAjax = function() {
    this.$view.find('ul.pager > li > a, ol.pager > li > a, th.views-field a, .attachment .views-summary a')
      .each(jQuery.proxy(this.attachPagerLinkAjax, this));
  };

  /**
   * Attach the ajax behavior to a single link.
   */
  Drupal.views.ajaxView.prototype.attachPagerLinkAjax = function(id, link) {
    var $link = $(link);
    var viewData = {};
    var href = $link.attr('href');
    // Don't attach to pagers inside nested views.
    if ($link.closest('.view')[0] !== this.$view[0] &&
      $link.closest('.view').parent().hasClass('attachment') === false) {
      return;
    }

    // Provide a default page if none has been set. This must be done
    // prior to merging with settings to avoid accidentally using the
    // page landed on instead of page 1.
    if (typeof(viewData.page) === 'undefined') {
      viewData.page = 0;
    }

    // Construct an object using the settings defaults and then overriding
    // with data specific to the link.
    $.extend(
      viewData,
      this.settings,
      Drupal.Views.parseQueryString(href),
      // Extract argument data from the URL.
      Drupal.Views.parseViewArgs(href, this.settings.view_base_path)
    );

    // For anchor tags, these will go to the target of the anchor rather
    // than the usual location.
    $.extend(viewData, Drupal.Views.parseViewArgs(href, this.settings.view_base_path));

    this.element_settings.submit = viewData;
    this.pagerAjax = new Drupal.ajax(false, $link, this.element_settings);
    this.links.push(this.pagerAjax);
  };

  Drupal.ajax.prototype.commands.viewsScrollTop = function (ajax, response, status) {
    // Scroll to the top of the view. This will allow users
    // to browse newly loaded content after e.g. clicking a pager
    // link.
    var offset = $(response.selector).offset();
    // We can't guarantee that the scrollable object should be
    // the body, as the view could be embedded in something
    // more complex such as a modal popup. Recurse up the DOM
    // and scroll the first element that has a non-zero top.
    var scrollTarget = response.selector;
    while ($(scrollTarget).scrollTop() == 0 && $(scrollTarget).parent()) {
      scrollTarget = $(scrollTarget).parent();
    }
    // Only scroll upward.
    if (offset.top - 10 < $(scrollTarget).scrollTop()) {
      $(scrollTarget).animate({scrollTop: (offset.top - 10)}, 500);
    }
  };

})(jQuery);
;
(function ($) {

Drupal.googleanalytics = {};

$(document).ready(function() {

  // Attach mousedown, keyup, touchstart events to document only and catch
  // clicks on all elements.
  $(document.body).bind("mousedown keyup touchstart", function(event) {

    // Catch the closest surrounding link of a clicked element.
    $(event.target).closest("a,area").each(function() {

      // Is the clicked URL internal?
      if (Drupal.googleanalytics.isInternal(this.href)) {
        // Skip 'click' tracking, if custom tracking events are bound.
        if ($(this).is('.colorbox') && (Drupal.settings.googleanalytics.trackColorbox)) {
          // Do nothing here. The custom event will handle all tracking.
          //console.info("Click on .colorbox item has been detected.");
        }
        // Is download tracking activated and the file extension configured for download tracking?
        else if (Drupal.settings.googleanalytics.trackDownload && Drupal.googleanalytics.isDownload(this.href)) {
          // Download link clicked.
          ga("send", {
            "hitType": "event",
            "eventCategory": "Downloads",
            "eventAction": Drupal.googleanalytics.getDownloadExtension(this.href).toUpperCase(),
            "eventLabel": Drupal.googleanalytics.getPageUrl(this.href),
            "transport": "beacon"
          });
        }
        else if (Drupal.googleanalytics.isInternalSpecial(this.href)) {
          // Keep the internal URL for Google Analytics website overlay intact.
          ga("send", {
            "hitType": "pageview",
            "page": Drupal.googleanalytics.getPageUrl(this.href),
            "transport": "beacon"
          });
        }
      }
      else {
        if (Drupal.settings.googleanalytics.trackMailto && $(this).is("a[href^='mailto:'],area[href^='mailto:']")) {
          // Mailto link clicked.
          ga("send", {
            "hitType": "event",
            "eventCategory": "Mails",
            "eventAction": "Click",
            "eventLabel": this.href.substring(7),
            "transport": "beacon"
          });
        }
        else if (Drupal.settings.googleanalytics.trackOutbound && this.href.match(/^\w+:\/\//i)) {
          if (Drupal.settings.googleanalytics.trackDomainMode !== 2 || (Drupal.settings.googleanalytics.trackDomainMode === 2 && !Drupal.googleanalytics.isCrossDomain(this.hostname, Drupal.settings.googleanalytics.trackCrossDomains))) {
            // External link clicked / No top-level cross domain clicked.
            ga("send", {
              "hitType": "event",
              "eventCategory": "Outbound links",
              "eventAction": "Click",
              "eventLabel": this.href,
              "transport": "beacon"
            });
          }
        }
      }
    });
  });

  // Track hash changes as unique pageviews, if this option has been enabled.
  if (Drupal.settings.googleanalytics.trackUrlFragments) {
    window.onhashchange = function() {
      ga("send", {
        "hitType": "pageview",
        "page": location.pathname + location.search + location.hash
      });
    };
  }

  // Colorbox: This event triggers when the transition has completed and the
  // newly loaded content has been revealed.
  if (Drupal.settings.googleanalytics.trackColorbox) {
    $(document).bind("cbox_complete", function () {
      var href = $.colorbox.element().attr("href");
      if (href) {
        ga("send", {
          "hitType": "pageview",
          "page": Drupal.googleanalytics.getPageUrl(href)
        });
      }
    });
  }

});

/**
 * Check whether the hostname is part of the cross domains or not.
 *
 * @param string hostname
 *   The hostname of the clicked URL.
 * @param array crossDomains
 *   All cross domain hostnames as JS array.
 *
 * @return boolean
 */
Drupal.googleanalytics.isCrossDomain = function (hostname, crossDomains) {
  /**
   * jQuery < 1.6.3 bug: $.inArray crushes IE6 and Chrome if second argument is
   * `null` or `undefined`, https://bugs.jquery.com/ticket/10076,
   * https://github.com/jquery/jquery/commit/a839af034db2bd934e4d4fa6758a3fed8de74174
   *
   * @todo: Remove/Refactor in D8
   */
  if (!crossDomains) {
    return false;
  }
  else {
    return $.inArray(hostname, crossDomains) > -1 ? true : false;
  }
};

/**
 * Check whether this is a download URL or not.
 *
 * @param string url
 *   The web url to check.
 *
 * @return boolean
 */
Drupal.googleanalytics.isDownload = function (url) {
  var isDownload = new RegExp("\\.(" + Drupal.settings.googleanalytics.trackDownloadExtensions + ")([\?#].*)?$", "i");
  return isDownload.test(url);
};

/**
 * Check whether this is an absolute internal URL or not.
 *
 * @param string url
 *   The web url to check.
 *
 * @return boolean
 */
Drupal.googleanalytics.isInternal = function (url) {
  var isInternal = new RegExp("^(https?):\/\/" + window.location.host, "i");
  return isInternal.test(url);
};

/**
 * Check whether this is a special URL or not.
 *
 * URL types:
 *  - gotwo.module /go/* links.
 *
 * @param string url
 *   The web url to check.
 *
 * @return boolean
 */
Drupal.googleanalytics.isInternalSpecial = function (url) {
  var isInternalSpecial = new RegExp("(\/go\/.*)$", "i");
  return isInternalSpecial.test(url);
};

/**
 * Extract the relative internal URL from an absolute internal URL.
 *
 * Examples:
 * - https://mydomain.com/node/1 -> /node/1
 * - https://example.com/foo/bar -> https://example.com/foo/bar
 *
 * @param string url
 *   The web url to check.
 *
 * @return string
 *   Internal website URL
 */
Drupal.googleanalytics.getPageUrl = function (url) {
  var extractInternalUrl = new RegExp("^(https?):\/\/" + window.location.host, "i");
  return url.replace(extractInternalUrl, '');
};

/**
 * Extract the download file extension from the URL.
 *
 * @param string url
 *   The web url to check.
 *
 * @return string
 *   The file extension of the passed url. e.g. "zip", "txt"
 */
Drupal.googleanalytics.getDownloadExtension = function (url) {
  var extractDownloadextension = new RegExp("\\.(" + Drupal.settings.googleanalytics.trackDownloadExtensions + ")([\?#].*)?$", "i");
  var extension = extractDownloadextension.exec(url);
  return (extension === null) ? '' : extension[1];
};

})(jQuery);
;
