import matplotlib.pyplot as plt
import numpy as np

month = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"]
electricity = [534.12, 442.87, 624.21, 712.23, 537.12, 655.14, 232.50, 364.58, 327.33, 244.98, 374.63, 482.75]
water = [101.44, 88.46, 73.47, 90.45, 47.55, 63.21, 74.89, 105.22, 108.25, 160.74, 88.41, 120.47]

#https://matplotlib.org/stable/gallery/text_labels_and_annotations/legend.html#sphx-glr-gallery-text-labels-and-annotations-legend-py
fig, ax = plt.subplots()
ax.plot(month, electricity, water)
ax.plot(electricity, label = "Electricity")
ax.plot(water, label = "Water")

ax.set(xlabel="Month", ylabel="Cost (THB)",
       title = "Water and Electricity Monthly Bills 2021")
ax.grid() #แสดง grid

legend = ax.legend(loc = "upper right", fontsize = "large")
legend.get_frame()
plt.show()
