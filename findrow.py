import random
import matplotlib.pyplot as plt
import matplotlib.patches as patches

# Components with bottom left (x1,y1) and top right(x2,y2) 
class Component:
    def __init__(self, id, x1, y1, x2, y2):
        self.id = id
        self.x1 = x1
        self.y1 = y1
        self.x2 = x2
        self.y2 = y2
        self.row = None  

# creating random component data 
def generate_random_components(seed=None):
    random.seed(seed)
    components = []
    for i in range(1, 25):
        x1 = random.randint(0, 100)
        y1 = random.randint(0, 500)
        x2 = x1 + random.randint(20, 50)
        y2 = y1 + random.randint(20, 50)
        components.append(Component(i, x1, y1, x2, y2))
    return components

# Function to group components into rows based on range overlap
def group_components_into_rows(components):
    components.sort(key=lambda comp: comp.y1, reverse=True)
    
    rows = []
    current_row = []
    row_number = 1
    
    for component in components:
        if not current_row or overlap(current_row[-1], component):
            current_row.append(component)
            component.row = row_number  # Assign row number to the component
        else:
            rows.append(current_row)
            current_row = [component]
            row_number += 1
            component.row = row_number  # Assign row number to the component
    
    if current_row:
        rows.append(current_row)
    
    return rows

def overlap(comp1, comp2):
    return comp1.y1 < comp2.y2 and comp1.y2 > comp2.y1

def visualize_components(title, rows):
    fig, ax = plt.subplots(figsize=(10, 8))
    
    colors = plt.cm.get_cmap('tab20', len(rows))
    
    for row_num, row in enumerate(rows, start=1):
        color = colors(row_num - 1)  
        for comp in row:
            rect = patches.Rectangle((comp.x1, comp.y1), comp.x2 - comp.x1, comp.y2 - comp.y1, 
                                     linewidth=1, edgecolor='black', facecolor=color)
            ax.add_patch(rect)
            
            plt.text(comp.x1 + (comp.x2 - comp.x1) / 2, comp.y1 + (comp.y2 - comp.y1) / 2, 
                     str(comp.id), color='black', ha='center', va='center')
    
    ax.set_xlim(0, 150)  
    ax.set_ylim(0, 550)
    
    ax.set_xlabel('X coordinate')
    ax.set_ylabel('Y coordinate')
    plt.title(title)
    
    plt.gca().invert_yaxis()
    plt.show()

# Generate random components
random_components = generate_random_components(seed=2)

# Group components into rows
rows_random = group_components_into_rows(random_components)

row_values = [component.row for component in random_components]

print("Row values for each component:")
for component in random_components:
    print(f"Component {component.id}: Row {component.row}")


# Visualize components
visualize_components('Random generated Components and their respective rows', rows_random)