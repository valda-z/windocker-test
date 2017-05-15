# windocker-test

example for deploying Application Gateway with VM's scale set for demonstrating windows docker image running on scale set farm
* App gateway has HTTP rules for load balancing to scale set farm
* Scale set is deployed with Script Extension, script itself starts docker container `docker -d -p 80:80 --restart=always valda/webtest`
* web app server from socker images showing `COMPUTERNAME` to demonstrate that we are running in vmss



[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fvalda-z%2Fwindocker-test%2Fmaster%2Finfra%2Fazuredeploy.json)