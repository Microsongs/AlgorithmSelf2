#include <iostream>

class Node {
public:
	Node* next;
	Node* prev;
	int data;
	static inline Node* insertNode(int data) {
		Node* node = new Node();
		node->data = data;
		node->next = NULL;
		node->prev = NULL;
		return node;
	}
};

class Queue {
public:
	Queue() {
		front = rear = NULL;
		size = 0;
	}
	Node* front;
	Node* rear;
	int size;
};

int main() {
	Queue* queue = new Queue();

	int n;
	scanf_s("%d", &n);
	for (int i = 0; i < n; i++) {
		std::string input;
		std::cin >> input;
		if (input == "push_front") {
			int data;
			scanf_s("%d", &data);
			Node* temp = Node::insertNode(data);
			if (queue->front == NULL)
				queue->rear = queue->front = temp;
			else {
				temp->next = queue->front;
				queue->front->prev = temp;
				queue->front = temp;
			}
			queue->size++;
		}
		else if (input == "push_back") {
			int data;
			scanf_s("%d", &data);
			Node* temp = Node::insertNode(data);
			if (queue->rear == NULL)
				queue->rear = queue->front = temp;
			else {
				temp->prev = queue->rear;
				queue->rear->next = temp;
				queue->rear = temp;
			}
			queue->size++;
		}
		else if (input == "pop_front") {
			if (queue->size == 0)
				printf("-1\n");
			else {
				printf("%d\n", queue->front->data);
				Node* temp = queue->front;
				queue->front = queue->front->next;
				free(temp);
				if (queue->front == NULL)
					queue->rear = NULL;
				else
					queue->front->prev = NULL;
				queue->size--;
			}
		}
		else if (input == "pop_back") {
			if (queue->size == 0)
				printf("-1\n");
			else {
				printf("%d\n", queue->rear->data);
				Node* temp = queue->rear;
				queue->rear = queue->rear->prev;
				if (queue->rear == NULL)
					queue->front = NULL;
				else
					queue->rear->next = NULL;
				queue->size--;
			}
		}
		else if (input == "size") {
			printf("%d\n", queue->size);
		}
		else if (input == "empty") {
			queue->size == 0 ? printf("1\n") : printf("0\n");
		}
		else if (input == "front") {
			if (queue->size == 0)
				printf("-1\n");
			else
				printf("%d\n", queue->front->data);
		}
		else if (input == "back") {
			if (queue->size == 0)
				printf("-1\n");
			else
				printf("%d\n", queue->rear->data);
		}
	}
}