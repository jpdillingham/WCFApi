# WCF Api

A simple .NET 3.5 console application demonstrating how to host a RESTful API with WCF

# From Scratch

1. Create a new console application (or Windows service, if that's what you need) and target .NET 3.5.
2. Add project references to `System.ServiceModel` and `System.ServiceModel.Web`
3. Create an interface and add the `ServiceContract` attribute
4. Add interface methods for your endpoints and add the `OperationContract` and `WebGet` or `WebInvoke` attributes to describe the corresponding HTTP operation
5. Implement your interface
6. In Main() (or your service entry point), instantiate `WebServiceHost`, add an endpoint with `AddServiceEndpoint()`, and open the host with `Open()`