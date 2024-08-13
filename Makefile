CLUSTER_NAME := k8s-cluster-local

up-local-cluster:
	kind create cluster --name $(CLUSTER_NAME)
	kubectl config use-context kind-$(CLUSTER_NAME) 
	
down-local-cluster:
	kind delete cluster --name $(CLUSTER_NAME)