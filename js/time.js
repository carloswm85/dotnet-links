// Last time page code was updated/changed
function lastUpdate()
{
	const options = {
		year: "numeric",
		month: "numeric",
		day: "numeric",
	};

	let last = document.lastModified;
	let date = new Date(last);
	let local = date.toLocaleDateString("en-US", options);
	let fullDate = `${local}`;
	document.getElementById("updated").textContent = fullDate;
}

lastUpdate();