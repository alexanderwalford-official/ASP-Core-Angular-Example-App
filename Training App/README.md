# ASP Angular .NET Core Application
Alexander Walford

## How do I add a new API endpoint?
1) Create a controller named SomethingController.cs in the "Controllers" folder.
2) Add entry to context list in proxy.confjs file.
3) Ensure you add the relevant tags to your controller file such as [Route("[controller]")] after the namespace and [HttpGet("your-sub-url")] for your methods.


## How do I add a new angular webpage / component?
1) Start a new terminal in the angular project folder, "ClientApp".
2) Type: ng generate component your-component
3) The .ts file is used to interact with the backend API.
4) You can import UI libraries and do normal HTML as you'd expect.