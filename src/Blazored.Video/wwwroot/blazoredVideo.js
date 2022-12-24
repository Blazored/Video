﻿if (!window.BlazoredVideo) {
	window.BlazoredVideo = {
		setProperty: function (el, name, value) {
			if (!el) {
				return;
			}
			try {
				el[name] = value;
			} catch (e) {
				console.error(e);
			}
		},
		getProperty: function (el, name) {
			if (!el) {
				return null;
			}
			try {
				var value = el[name];

				// the default TimeRanges and TextTracks array are custom enumerations and cannot be processed by the json serializer
				//  therefor we must convert them to plain objects

				if (value instanceof TimeRanges) {
					let items = new Array();
					for (var i = 0; i < value.length; i++) {
						let item = {
							index: i,
							start: value.start(i),
							end: value.end(i)
						};
						items.push(item);
					}
					value = items;
				}
				if (value instanceof TextTrackList) {
					let items = new Array();
					for (var i = 0; i < value.length; i++) {
						let item = value[i];
						items.push(item);
					}
					value = items;
				}
				return value;
			} catch (e) {
				console.error(e);
				return null;
			}
		},
		invoke: function (el, name, ...arguments) {
			if (!el) {
				return null;
			}
			try {
				return el[name](...arguments);
			} catch (e) {
				console.error(e);
				return null;
			}
		},
		registerCustomEventHandler: function (el, eventName, payload) {
			if (!(el && eventName)) {
				return false;
			}
			if (!el.hasOwnProperty("customEvent")) {
				el["customEvent"] = function (eventName, payload) {

					this["value"] = getJSON(this, eventName, payload);

					var event;
					if (typeof (Event) === "function") {
						event = new Event("change");
					} else {
						event = document.createEvent("Event");
						event.initEvent("change", true, true);
					}

					this.dispatchEvent(event);
				};
			}

			if (window.jQuery) {
				jQuery(el).on(eventName, function () { el.customEvent(eventName, payload) });
			} else {
				el.addEventListener(eventName, function () { el.customEvent(eventName, payload) });
			}


			// Craft a bespoke json string to serve as a payload for the event
			function getJSON(el, eventName, payload) {
				if (payload && payload.length > 0) {
					// this syntax copies just the properties we request from the source element
					// IE 11 compatible
					let data = {};
					for (var obj in payload) {
						var item = payload[obj];
						if (el[item]) {
							data[item] = el[item];
						}
					}

					// this stringify overload eliminates undefined/null/empty values
					return JSON.stringify(
						{ name: eventName, state: data },
						function (k, v) { return (v === undefined || v == null || v.length === 0) ? undefined : v }
					);
				} else {
					return JSON.stringify(
						{ name: eventName }
					);
				}
			}
		}
	};
}