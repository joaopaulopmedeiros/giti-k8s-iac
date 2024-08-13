CLUSTER_NAME := k8s-cluster-local

up-local-cluster:
	kind create cluster --name $(CLUSTER_NAME)
	kubectl config use-context kind-$(CLUSTER_NAME) 
	kubectl create namespace argocd
	kubectl apply -n argocd -f https://raw.githubusercontent.com/argoproj/argo-cd/stable/manifests/install.yaml

down-local-cluster:
	kind delete cluster --name $(CLUSTER_NAME)