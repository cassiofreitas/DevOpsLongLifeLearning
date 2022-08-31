# hello.py
""" Simple Hello, World example with PyQt6."""
""" https://realpython.com/python-pyqt-gui-calculator/#getting-to-know-pyqt """

import sys

# 1. Import Application and all the required widgets
from PyQt6.QtWidgets import QApplication, QLabel, QWidget

# 2. Create an instance of QApplication
app = QApplication([])

# 3. Create your application´s GUI
window = QWidget()
window.setWindowTitle("PyQt App")
window.setGeometry(100,100,280,80)
helloMsg = QLabel("<h1>Hello, World</h1>", parent=window)
helloMsg.move(60,15)

# 4. Show your application's event loop
window.show()

# 5. Run your application's event loop
sys.exit(app.exec())
