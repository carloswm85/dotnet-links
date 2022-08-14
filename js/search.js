addEventListener("onkeyup", Search);

function Search() {
	var content = [];
	buttons = document.getElementsByTagName("button");
	Validate(buttons); 
}

/**
 * If the character is found in the string,
 * the function returns.
 * @param {any} content every element
 */
function Validate(content) {
	var input, filter;
	input = document.getElementById("searchBox");
	filter = input.value.toUpperCase();
  for (i = 0; i < content.length; i++) {
		a = content[i];
		txtValue = a.textContent || a.innerText;
		if (txtValue.toUpperCase().indexOf(filter) > -1) {
			content[i].style.display = "";
		} else {
			content[i].style.display = "none";
		}
	}
}