window.outsideClickHandler = {
	addEvent: function (elementId, dotnetHelper) {
		window.addEventListener("click", (e) => {
			if (!document.getElementById(elementId).contains(e.target)) {
				dotnetHelper.invokeMethodAsync("InvokeClickOutside");
			}
		});
	}
};