#!/bin/bash

api="https://api.bedrockinfo.com/v2"
user_agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36"

function get_server_status() {
	# 1 - address: (string): <address>
	# 2 - port: (integer): <port - default: 19132>
	# 3 - history: (integer): <history - default: 5>
	curl --request GET \
		--url "$api/status?server=$1&port=${2:-19132}&history=${3:-5}" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}
