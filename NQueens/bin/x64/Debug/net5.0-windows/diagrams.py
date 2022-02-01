import numpy as np
import matplotlib.pyplot as plt

avg = [9.4, 7.9, 6.5, 7, 6.9, 6.4, 6.1, 5.6, 6.4, 6.3, 6.2, 7.1, 6.3, 6.5, 5.8, 7, 6.5, 6.2, 6.2, 6, 5.7, 6.1, 4.6, 5.3, 4.7, 6.8, 5.8, 4.3, 5.3, 3.9, 5.8, 6.4, 5.1, 4.6, 5.5, 5.8, 5.6, 6.8, 5.2, 5.1, 4.6, 4.3, 4.6, 3.7, 3.5, 4.2, 4, 3.9, 4.8, 4.5, 4.6, 4, 4.6, 4.4, 3.9, 3.9, 4.4, 4.4, 4.7, 4.2, 4.2, 3.5, 4.1, 4.4, 4.3, 4.1, 5.3, 4, 4.6, 4.7, 4.9, 4, 4.1, 3.6, 5.5, 5.8, 5.8, 7, 8.2, 6.8, 6, 5.7, 5, 5.2, 4.7, 4.8, 4, 4.5, 4.1, 6.3, 4.7, 5.2, 5.4, 4.5, 4.5, 4.9, 4.6, 4.2, 5.2, 3.6, ]
best = [7, 5, 6, 6, 5, 6, 3, 3, 6, 6, 6, 6, 5, 6, 5, 6, 4, 5, 5, 5, 5, 5, 3, 4, 3, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 4, 3, 3, 4, 3, 4, 3, 3, 3, 4, 3, 3, 3, 3, 3, 4, 4, 4, 3, 3, 4, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 3, 4, 3, 4, 4, 4, 4, 3, 4, 4, 5, 3, 4, 3, 4, 4, 4, 2, 4, 4, 4, 4, 3, 3, 3, 3, 3, ]

plt.subplot(2, 2, 1)
plt.plot(np.arange(0, len(best)), best)
plt.xlabel('Generations');
plt.ylabel('Value');
plt.legend(['Best'])

plt.subplot(2, 2, 2)
plt.plot(np.arange(0, len(avg)), avg)
plt.xlabel('Generations');
plt.ylabel('Value');
plt.legend(['Average'])

plt.subplot(2, 2, (3, 4))
plt.plot(np.arange(0, len(avg)), best)
plt.plot(np.arange(0, len(avg)), avg)
plt.xlabel('Generations');
plt.ylabel('Value');
plt.legend(['Best', 'Average'])

plt.show()
