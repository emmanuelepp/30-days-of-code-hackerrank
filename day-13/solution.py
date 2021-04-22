from abc import ABCMeta, abstractmethod


class MyBook(Book):
    def __init__(self, title, author, price):
        self.title = title
        self.author = author
        self.price = price

    @abstractmethod
    def display(self):
        print(f"Title: {title}")
        print(f"Author: {author}")
        print(f"Price: {str(price)}")
