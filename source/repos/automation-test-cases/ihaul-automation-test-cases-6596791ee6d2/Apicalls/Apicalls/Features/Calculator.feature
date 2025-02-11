Feature:apicalls
Scenario: getdata
Given end point is"http://15.206.27.64/api/v1/admin/getAllUsers"
When pass authorization header
When send get request give me details
Then the response status code should be 200
And the response content should contain expected
And print all phone numbers and emails from the responsee
