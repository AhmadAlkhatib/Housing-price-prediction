#initializing variables
$URL= "https://www.sahibinden.com/satilik?pagingSize=50&address_region=1"
$offset=0
$Page = Invoke-WebRequest -Uri $URL
$locationsText=""
$roomsAndSizeText=""
$pricesText=""

For($i=0; $i -le 50; $i++)
{
	" $i  to go"
	#location--------------------------------
	$temp = $Page.ParsedHtml.body.getElementsByTagName('td') | Where {$_.getAttributeNode('class').Value -eq 'searchResultsLocationValue'}
	$locations = $temp.innerText -replace "`n"," " -replace "`r",""

	#rooms and size--------------------------
	$temp = $Page.ParsedHtml.body.getElementsByTagName('td') | Where {$_.getAttributeNode('class').Value -eq 'searchResultsAttributeValue'}
	$roomsAndSizes = $temp.innerText -replace "`n"," " -replace "`r"," "

	#prices-----------------------------------
	$temp = $Page.ParsedHtml.body.getElementsByTagName('td') | Where {$_.getAttributeNode('class').Value -eq 'searchResultsPriceValue'}
	$prices = $temp.innerText -replace "`n"," " -replace "`r"," "

	#Links-------------------------------------
	$links = $Page.ParsedHtml.getElementsByTagName('td') | Where-Object { $_.className -eq 'searchResultsLargeThumbnail' } | ForEach-Object { $_.getElementsByTagName('a') } | Select-Object -Expand href
	
	#inner data from links---------------------
	$website = "https://www.sahibinden.com"
	$j=0
	For($k=0; $k -lt $links.Length;$k++){
		"$k link"
		$garbage,$temp = $links[$k].split(':')
		$link = $website + $temp


		function qsa($req, $selector) {
		   $collection = $req.ParsedHtml.querySelectorAll($selector)
           foreach ($i in 0..($collection.length - 1)) { $collection.item($i) }
		}

		$req = Invoke-WebRequest -Uri $link
		#age and story
		$text = (qsa $req '.classifiedInfo .classifiedInfoList li span[class=""]').textContent 

		#lons and lats
		$tag = $req.ParsedHtml.body.getElementsByTagName('div') | Where {$_.getAttributeNode('id').Value -eq 'gmap'}
		$temp = $tag.outerHTML.split('"')
		$lons = $temp[5]
		$lats = $temp[7]

		#final export
		$temp1 = $locations[$k]
		$temp2 = $roomsAndSizes[$j]
		$temp3 = $roomsAndSizes[$j+1]
		$j+=2
		$temp4 = $text[2]
		$temp5 = $text[3]
		$temp6 = $lons
		$temp7 = $lats
		$temp8 = $prices[$k]

		"$temp1,$temp2,$temp3,$temp4,$temp5,$temp6,$temp7,$temp8" | Add-Content test.csv
	}

	$offset+=50                             #--------------------#
	$URL="https://www.sahibinden.com/satilik?pagingOffset=$offset&pagingSize=50&address_region=1"
	$Page = Invoke-WebRequest -Uri $URL
}