body {
    color: #000000;
    font-family: Verdana,arial,Helvetica,sans-serif;
    font-size: 90%;
}

.outerwrapper {
	/*display: none;*/
	width: 630px;	
	position: relative;
}

.outerwrapper .visually-hidden {
	width:1px;
	height:1px;
	position: absolute !important;
	clip: rect(1px 1px 1px 1px); /* IE6, IE7 */
	clip: rect(1px, 1px, 1px, 1px);
}


.outerwrapper .timeline {
	width: 630px;
	height: 260px;
}

.outerwrapper .timeline-header {
	position: absolute;
	top: -4px;
	left: 120px;
	width: 500px;
	height: 110px;
	z-index: 10;
}

.outerwrapper .timeline-header h2 {
	font-size: 1.3em;
	margin: 0 0 1em 0;
	color: #666;
}

.outerwrapper .timeline-header h3 {
	margin: 0 0 0.5em 0;
	color: #999;
}


.outerwrapper .info-box {
	position: relative;
	top: 0px;
	width: 630px;
	height: 320px;
	opacity: 1;
	border-top: 2px solid #999999;
	border-bottom: 2px solid #999999;
	z-index: 10;
	background: white;
	overflow: hidden;
}

.outerwrapper div[class^='event'] {
	position: relative;
	float: left;	
	width: 630px;
	padding: 10px 0;

}


.outerwrapper .info-box div[class^='event'] h3 {
	margin: 0 0 1em 5px;
	color: #666;
}

.outerwrapper .info-box div[class^='event'] h4 {
	margin: 0 0 0 5px;
	color: #999;
	font-style: italic;
}

.outerwrapper .info-box div[class^='event'] p {
	margin: 0 0 0 5px;
}

.outerwrapper .info-box div[class^='event'] img {
	float: right;
	margin: 0 5px 0 10px;
	max-width: 300px;
}

.outerwrapper .info-box div[class^='event'] a:before {
	content:url(http://www.nature.com/polopoly_fs/7.7008.1350920391!/image/link.jpg);
}

.outerwrapper .info-box div[class^='event'] .credit {
	margin: 0.8em 0 0 0;
}

.outerwrapper .info-box div[class^='event'] .credit a:before {
	content:none;
}



.outerwrapper .tooltip
{
	display:none;
	position: absolute; 
	top: 110px;
	width: 135px;
	z-index: 999;
	margin-left: -75px;
	padding: 10px;
	background-color: #5E5E5E;
	text-align:center;
	opacity: 0;
	-webkit-transition: opacity 0.3s ease;                  
	-moz-transition: opacity 0.3s ease;                 
	-o-transition: opacity 0.3s ease;   
	-ms-transition: opacity 0.3s ease;          
	transition: opacity 0.3s ease;               
}

.outerwrapper .tooltip:after
{
	content: "";
	position:absolute;
	z-index: 1000;
	bottom: -8px;
	left: 50%;
	margin-left: -12px;
	border-top: 10px solid #5E5E5E;
	border-left: 10px solid transparent;
	border-right: 10px solid transparent;
	border-bottom: 0;
}

.outerwrapper .tooltip p {
	margin: 0;
	color: #FFF;
}

/* SVG
----------------------------------*/

.outerwrapper svg text {
	font: 13px sans-serif;
}

.outerwrapper svg .axis text, .outerwrapper svg .year-axis text {
	font: 11px sans-serif;
}

.outerwrapper svg .axis path, .outerwrapper svg .year-axis path {
	fill: none;
	stroke: none;
}

.outerwrapper svg .axis line {
	fill: none;
	stroke: #999999;
	shape-rendering: crispEdges;
}

.outerwrapper svg .year-axis line {
	stroke: none;
}

.outerwrapper svg .locations {
	fill: #999999;
	cursor: pointer;
	-webkit-transition: all 0.2s ease;                  
	-moz-transition: all 0.2s ease;                 
	-o-transition: all 0.2s ease;   
	-ms-transition: all 0.2s ease;          
	transition: all 0.2s ease;
}

.outerwrapper svg .locations:hover {
	fill: #EE8361;
}

.outerwrapper svg .selected {
	fill: #E85338;
}
