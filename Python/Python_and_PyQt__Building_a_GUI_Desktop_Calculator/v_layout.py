# v_layout.py

"""Vertical layout example."""

import sys

from PyQt6.QtWidgets import (
    QApplication,
    QVBoxLayout,
    QPushButton,
    QWidget,

)

app = QApplication([])
window = QWidget()
window.setWindowTitle("QVBoxLayout")

layout = QVBoxLayout()
layout.addWidget(QPushButton("Top"))
layout.addWidget(QPushButton("Center"))
layout.addWidget(QPushButton("Bottom"))
window.setLayout(layout)

window.show()
sys.exit(app.exec())

