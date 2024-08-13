# K8s - Infrastructure As Code

## Description
This repository addresses a proof of concept about a dockerized .net web api provisioned in kubernetes cluster.

<img src="./docs/argo/Screenshot 2024-08-13 at 01.27.38.png">

## How to run locally
_Ensure you get docker, kind and helm previously installed._

Create k8s cluster: `make create-local-cluster`

Destroy k8s cluster: `make delete-local-cluster`

## Extra Notes
[ArgoCD useful commands](./docs/argo)