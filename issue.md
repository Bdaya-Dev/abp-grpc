# Introduction
When adding gRPC to a commercial application using flutter as the frontend, we are currently facing the problem that abp modules (free and commercial) have no protobuf bindings available, so we have to create them from scratch.
however repeating this process for every new application is not optimal, so we wanted to unify the process.

To solve this, ABP should maintain its own protobuf bindings on a public schema registry (like [buf.build](https://buf.build/explore)) for both free and commercial modules, so that frontend developers can depend on it when adding gRPC to an app.

Abp should also maintain an up-to-date auto generated c# modules whenever those protobuf bindings are changed

# Details

## The protobuf files

the protobuf bindings (.proto files) can either be maintained on the main abp repository, or on a different one, but of course having them on the main repository is much better

they can also be split into modules using [buf cli](https://buf.build/product/cli) to match ABP's structure

## The generated code

a buf module outputs 3 different c# projects:
1. `.Grpc.Core`: using plugin https://buf.build/protocolbuffers/csharp , outputs just the messages, this project also defines mapping between protobuf messages and existing abp dtos in `.Application.Contracts` layer
2. `.Grpc.Server`: depends on `Grpc.Core`, using plugin https://buf.build/grpc/csharp with option `no_client`, outputs the service base class that need to be implemented to handle incoming grpc requests, this layer does the same thing as the `.HttpApi` layer
3. `.Grpc.Client`: depends on `Grpc.Core`, using plugin https://buf.build/grpc/csharp with option `no_server`, outputs the client bindings, this layer also introduces client proxy implementations of the application services in `.Application.Contracts` layer (similar to what `.HttpApi.Client` layer does)

# Example

as a demo, I have created [this organization on buf.build](https://buf.build/abp-framework-demo)
and [this repository](https://github.com/Bdaya-Dev/abp-grpc)

