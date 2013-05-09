/*
jQWidgets v2.8.3 (2013-Apr-29)
Copyright (c) 2011-2013 jQWidgets.
License: http://jqwidgets.com/license/
*/

try{(function(h,b){b.jqwidgets=b.jqwidgets||{};b.jqwidgets.knockout=function(y){var z=this;var A={},x=y.name;A.init=function(F,G,C,E){var B=b.utils.unwrapObservable(G());var I=b.toJS(B);if(y.reset){y.reset()}if(h.data(F)[x]==undefined){var D=[];h(F)[x]();widget=h.data(F)[x].instance;h.each(y,function(K,L){if(widget.hasOwnProperty(K)&&I.hasOwnProperty(K)){if(!widget.koupdating){widget.koupdatingFromObservable=true;try{var M=false;if(y.serialize){if(y.serialize(widget,K)){if(b.toJSON(I[K])!=b.toJSON(y.serialize(widget,K))){y.setProperty(widget,K,widget[K],I[K])}M=true}}if(!M){if(b.toJSON(I[K])!=b.toJSON(widget[K])){y.setProperty(widget,K,widget[K],I[K])}}}catch(J){y.setProperty(widget,K,widget[K],I[K])}D[K]=K;widget.koupdatingFromObservable=false}}});var H={};h.each(I,function(J,K){if(D[J]==undefined){H[J]=I[J]}});widget.host[x](H)}widget=h.data(F)[x].instance;widget.koupdatingFromObservable=false;widget.koupdating=false;if(y.events){h.each(y.events,function(){var J=this;h(F).on(J+"."+F.id,function(K){widget=h.data(F)[x].instance;if(!widget.koupdatingFromObservable){widget.koupdating=true;var M=G();var L=y.getProperty(widget,K,J,B);if(L!=undefined){if(M.hasOwnProperty(L.name)&&h.isFunction(M[L.name])){if(b.isObservable(M[L.name])&&M[L.name].push){G(L.value)}else{M[L.name](L.value)}}else{if(M[L.name]){G(L.value)}}}widget.koupdating=false}})})}};A.update=function(F,G,D,E,C){var B=b.utils.unwrapObservable(G());var H=b.toJS(B);widget=h.data(F)[x].instance;if(widget.koupdating){return}h.each(y,function(I,J){if(widget.hasOwnProperty(I)&&H.hasOwnProperty(I)){if(!widget.koupdating){widget.koupdatingFromObservable=true;var K=false;if(y.serialize){if(y.serialize(widget,I)){if(b.toJSON(H[I])!=b.toJSON(y.serialize(widget,I))){y.setProperty(widget,I,widget[I],H[I])}K=true}}if(!K){if(b.toJSON(H[I])!=b.toJSON(widget[I])){y.setProperty(widget,I,widget[I],H[I])}}widget.koupdatingFromObservable=false}}})};b.bindingHandlers[y.name]=A};var t=new b.jqwidgets.knockout({name:"jqxGauge",disabled:false,min:0,max:220,value:0,reset:function(){this.value=0;this.max=220;this.min=0;this.disabled=false},getProperty:function(y,z,x){},setProperty:function(x,y,z,A){if(y=="disabled"){x.host.jqxGauge({disabled:A})}if(y=="min"){x.host.jqxGauge({min:A})}if(y=="max"){x.host.jqxGauge({max:A})}if(y=="value"){x.host.jqxGauge({value:A})}}});var d=new b.jqwidgets.knockout({name:"jqxLinearGauge",disabled:false,min:0,max:220,value:0,reset:function(){this.value=0;this.max=220;this.min=0;this.disabled=false},getProperty:function(y,z,x){},setProperty:function(x,y,z,A){if(y=="disabled"){x.host.jqxLinearGauge({disabled:A})}if(y=="min"){x.host.jqxLinearGauge({min:A})}if(y=="max"){x.host.jqxLinearGauge({max:A})}if(y=="value"){x.host.jqxLinearGauge({value:A})}}});var s=new b.jqwidgets.knockout({name:"jqxSlider",disabled:false,min:0,max:10,value:0,reset:function(){this.value=0;this.max=10;this.min=0;this.disabled=false},events:["change"],getProperty:function(y,z,x){if(x=="change"){return{name:"value",value:z.args.value}}},setProperty:function(x,y,z,A){if(y=="disabled"){x.host.jqxSlider({disabled:A})}if(y=="min"){x.host.jqxSlider({min:parseFloat(A)})}if(y=="max"){x.host.jqxSlider({max:parseFloat(A)})}if(y=="value"){x.host.jqxSlider({value:parseFloat(A)})}}});var n=new b.jqwidgets.knockout({name:"jqxScrollBar",disabled:false,min:0,max:10,value:0,reset:function(){this.value=0;this.max=10;this.min=0;this.disabled=false},events:["valuechanged"],getProperty:function(y,z,x){if(x=="valuechanged"){return{name:"value",value:parseInt(z.currentValue)}}},setProperty:function(x,y,z,A){if(y=="disabled"){x.host.jqxScrollBar({disabled:A})}if(y=="min"){x.host.jqxScrollBar({min:parseFloat(A)})}if(y=="max"){x.host.jqxScrollBar({max:parseFloat(A)})}if(y=="value"){x.host.jqxScrollBar({value:parseFloat(A)})}}});var a=new b.jqwidgets.knockout({name:"jqxProgressBar",disabled:false,value:0,reset:function(){this.value=0;this.disabled=false},events:["valuechanged"],getProperty:function(y,z,x){if(x=="valuechanged"){return{name:"value",value:parseInt(z.currentValue)}}},setProperty:function(x,y,z,A){if(y=="disabled"){x.host.jqxProgressBar({disabled:A})}if(y=="value"){x.host.jqxProgressBar({value:parseFloat(A)})}}});var e=new b.jqwidgets.knockout({name:"jqxButton",disabled:false,reset:function(){this.disabled=false},getProperty:function(y,z,x){},setProperty:function(x,y,z,A){if(y=="disabled"){x.host.jqxButton({disabled:A})}}});var g=new b.jqwidgets.knockout({name:"jqxCheckBox",checked:false,disabled:false,reset:function(){this.checked=false;this.disabled=false},events:["change"],getProperty:function(y,z,x){if(x=="change"){return{name:"checked",value:z.args.checked}}},setProperty:function(x,y,z,A){if(y=="disabled"){x.host.jqxCheckBox({disabled:A})}if(y=="checked"){if(z!=A){x.host.jqxCheckBox({checked:A})}}}});var u=new b.jqwidgets.knockout({name:"jqxRadioButton",checked:false,disabled:false,reset:function(){this.checked=false;this.disabled=false},events:["change"],getProperty:function(y,z,x){if(x=="change"){return{name:"checked",value:z.args.checked}}},setProperty:function(x,y,z,A){if(y=="disabled"){x.host.jqxRadioButton({disabled:A})}if(y=="checked"){if(z!=A){x.host.jqxRadioButton({checked:A})}}}});var m=new b.jqwidgets.knockout({name:"jqxDateTimeInput",value:null,disabled:false,reset:function(){this.value=null;this.disabled=false},events:["valuechanged"],getProperty:function(y,z,x){if(x=="valuechanged"){return{name:"value",value:z.args.date}}},setProperty:function(x,y,z,A){if(y=="value"){x.setDate(A)}if(y=="disabled"){x.host.jqxDateTimeInput({disabled:A})}}});var w=new b.jqwidgets.knockout({name:"jqxCalendar",value:null,disabled:false,reset:function(){this.value=null;this.disabled=false},events:["valuechanged"],getProperty:function(y,z,x){if(x=="valuechanged"){return{name:"value",value:z.args.date}}},setProperty:function(x,y,z,A){if(y=="value"){x.setDate(A)}if(y=="disabled"){x.host.jqxCalendar({disabled:A})}}});var o=new b.jqwidgets.knockout({name:"jqxNumberInput",value:null,events:["valuechanged"],disabled:false,reset:function(){this.value=null;this.disabled=false},getProperty:function(y,z,x){if(x=="valuechanged"){return{name:"value",value:y.val()}}},setProperty:function(x,y,z,A){if(y=="value"){x.host.jqxNumberInput("val",A)}if(y=="disabled"){x.host.jqxNumberInput({disabled:A})}}});var j=new b.jqwidgets.knockout({name:"jqxMaskedInput",value:null,events:["valuechanged"],disabled:false,reset:function(){this.value=null;this.disabled=false},getProperty:function(y,z,x){if(x=="valuechanged"){return{name:"value",value:y.val()}}},setProperty:function(x,y,z,A){if(y=="value"){x.host.jqxMaskedInput("val",A)}if(y=="disabled"){x.host.jqxMaskedInput({disabled:A})}}});var c=new b.jqwidgets.knockout({name:"jqxListBox",source:null,disabled:false,selectedIndex:-1,reset:function(){this.disabled=false;this.selectedIndex=-1;this.source=null},events:["change"],getProperty:function(y,z,x){if(x=="change"){this.selectedIndex=y.selectedIndex;return{name:"selectedIndex",value:y.selectedIndex}}},setProperty:function(x,y,A,B){if(y=="source"){x.source=B;x.refresh()}if(y=="disabled"){x.disabled=B;x._renderItems()}if(y=="selectedIndex"){var z=x.disabled;x.disabled=false;x.selectIndex(B);x.disabled=z;if(z){x._renderItems()}}}});var p=new b.jqwidgets.knockout({name:"jqxDropDownList",source:null,disabled:false,selectedIndex:-1,reset:function(){this.disabled=false;this.selectedIndex=-1;this.source=null},events:["change"],getProperty:function(y,z,x){if(x=="change"){this.selectedIndex=y.selectedIndex;return{name:"selectedIndex",value:y.selectedIndex}}},setProperty:function(x,y,z,A){if(y=="source"){if(this.source!=A){this.source=A;x.host.jqxDropDownList({source:A})}}if(y=="disabled"){if(A!=this.disabled){this.disabled=A;x.host.jqxDropDownList({disabled:A})}}if(y=="selectedIndex"){if(A!=this.selectedIndex){this.selectedIndex=A;x.host.jqxDropDownList({selectedIndex:A})}}}});var i=new b.jqwidgets.knockout({name:"jqxComboBox",source:null,disabled:false,selectedIndex:-1,reset:function(){this.disabled=false;this.selectedIndex=-1;this.source=null},events:["change"],getProperty:function(y,z,x){if(x=="change"){this.selectedIndex=y.selectedIndex;return{name:"selectedIndex",value:y.selectedIndex}}},setProperty:function(x,y,z,A){if(y=="source"){if(this.source!=A){this.source=A;x.host.jqxComboBox({source:A})}}if(y=="disabled"){if(A!=this.disabled){this.disabled=A;x.host.jqxComboBox({disabled:A})}}if(y=="selectedIndex"){if(A!=this.selectedIndex){this.selectedIndex=A;x.host.jqxComboBox({selectedIndex:A})}}}});var v=new b.jqwidgets.knockout({name:"jqxTree",source:null,disabled:false,reset:function(){this.disabled=false;this.source=null},getProperty:function(y,z,x){},setProperty:function(x,y,z,A){if(y=="source"){if(this.source!=A){this.source=A;x.host.jqxTree({source:A})}}if(y=="disabled"){if(A!=this.disabled){this.disabled=A;x.host.jqxTree({disabled:A})}}}});var f=new b.jqwidgets.knockout({name:"jqxTabs",disabled:false,reset:function(){this.disabled=false},getProperty:function(y,z,x){},setProperty:function(x,y,z,A){if(y=="disabled"){if(A!=this.disabled){this.disabled=A;x.host.jqxTabs({disabled:A})}}}});var q=new b.jqwidgets.knockout({name:"jqxNavigationBar",disabled:false,reset:function(){this.disabled=false},getProperty:function(y,z,x){},setProperty:function(x,y,z,A){if(y=="disabled"){if(A!=this.disabled){this.disabled=A;x.host.jqxNavigationBar({disabled:A})}}}});var l=new b.jqwidgets.knockout({name:"jqxMenu",source:null,disabled:false,reset:function(){this.disabled=false;this.source=null},getProperty:function(y,z,x){},setProperty:function(x,y,z,A){if(y=="source"){if(this.source!=A){this.source=A;x.host.jqxMenu({source:A})}}if(y=="disabled"){if(A!=this.disabled){this.disabled=A;x.host.jqxMenu({disabled:A})}}}});var r=new b.jqwidgets.knockout({name:"jqxChart",source:null,disabled:false,reset:function(){this.disabled=false;this.source=null},getProperty:function(y,z,x){},setProperty:function(x,y,z,A){if(y=="source"){if(A!=this.source){this.source=A;var B=x.host.jqxChart("enableAnimations");x.host.jqxChart({enableAnimations:false});x.host.jqxChart({source:A});setTimeout(function(){x.host.jqxChart({enableAnimations:B})},1000)}}if(y=="disabled"){if(A!=this.disabled){this.disabled=A;x.host.jqxChart({disabled:A})}}}});var k=new b.jqwidgets.knockout({name:"jqxGrid",source:null,disabled:false,selectedRowIndex:-1,reset:function(){this.disabled=false;this.source=null;this.selectedRowIndex=-1},serialize:function(y,x){if(x=="source"){if(y.source&&y.source._source){return y.source.records}}return false},events:["cellvaluechanged","cellselect","rowselect"],getProperty:function(B,z,D,C){if(D=="cellvaluechanged"){var A=B.host.jqxGrid("getrowid",z.args.rowindex);var H=B.host.jqxGrid("getrowdata",A);var y=C.source;if(y!=undefined){var G={};var x={};var F=false;var E=false;h.each(y()[A],function(I,J){G[I]=J;x[I]="";if(b.isObservable(J)&&!b.isComputed(J)){F=true;J(H[I])}if(b.isObservable(J)&&b.isComputed(J)){E=true}});if(!F){G=H;y.replace(y()[A],x);y.replace(y()[A],G)}else{y.replace(y()[A],G)}if(E){B.host.jqxGrid("updaterow",A,b.toJS(y)[A])}return{name:"source",value:y}}}},setProperty:function(A,H,G,y){if(H=="selectedRowIndex"){A.host.jqxGrid("selectrow",y)}if(H=="source"){if(this.source==null||y==null){if(this.source!=y){this.source=y;var x={localdata:y,datatype:"local"};var F=new h.jqx.dataAdapter(x);A.host.jqxGrid({source:F})}}else{var x={localdata:y,datatype:"local"};var F=new h.jqx.dataAdapter(x);F.dataBind();if(!G.records||!F.records){return}var J=Math.max(G.records.length,F.records.length);var E=Math.abs(G.records.length-F.records.length);if(E==0){if(J>10){A.host.jqxGrid({source:F});return}}if(E>1){A.host.jqxGrid("beginupdate")}var I=new Array();for(var C=0;C<J;C++){var D=F.records[C];if(D==undefined){var z=A.host.jqxGrid("getrowid",C);I.push(z)}else{var B=G.records[C]!=undefined;if(B){if(b.toJSON(D)!=b.toJSON(G.records[C])){if(G.records[C].uid!=undefined){D.uid=G.records[C].uid;if(b.toJSON(D)==b.toJSON(G.records[C])){continue}}var z=A.host.jqxGrid("getrowid",C);A.host.jqxGrid("updaterow",z,D)}}else{A.host.jqxGrid("addrow",null,D)}}}if(I.length>0){A.host.jqxGrid("deleterow",I)}if(E>1){A.host.jqxGrid("endupdate")}}}if(H=="disabled"){if(y!=this.disabled){this.disabled=y;A.host.jqxGrid({disabled:y})}}}})}(jQuery,ko))}catch(error){};