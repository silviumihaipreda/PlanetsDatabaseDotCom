# PlanetsDatabaseDotCom
Contains endpoint and web app

The repository contains two VS2015 solutions. 

The first one is developed using nancy and owin (the endpoint) in order to avoid unnecessary middleware from being loaded. It is also constructed using a model-service-controller structure, but in the same folder. IoC is used to inject the service contract in the nancy module.

The second is simple empty solution with only one page. It uses angular to poll the endpoint for data, and a little bootstrap for layout.

The deployment process is simple: each can be deployed using VS2015 publish feature: choose web deploy. I have attached two pictures for the exact configuration. Note: IIS must be installed on the target machine.
