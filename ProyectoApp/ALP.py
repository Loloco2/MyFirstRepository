#App Launcher Project
import os
import json
import tkinter as tk
from tkinter import filedialog, messagebox, simpledialog

CONFIG_FILE = "launcher_config.json"

def load_config():
    if os.path.exists(CONFIG_FILE):
        with open(CONFIG_FILE, "r") as f:
            return json.load(f)
    return {}

def save_config(data):
    with open(CONFIG_FILE, "w") as f:
        json.dump(data, f, indent=4)

def add_category():
    name = simpledialog.askstring("Nueva Categoría", "Nombre de la categoría:")
    if name and name not in config:
        config[name] = []
        save_config(config)
        update_list()
    elif name:
        messagebox.showwarning("Error", "La categoría ya existe.")

def delete_category():
    selected = category_listbox.get(tk.ACTIVE)
    if selected:
        del config[selected]
        save_config(config)
        update_list()

def add_program():
    selected = category_listbox.get(tk.ACTIVE)
    if selected:
        file_path = filedialog.askopenfilename(title="Seleccionar programa")
        if file_path:
            config[selected].append(file_path)
            save_config(config)
            update_list()

def delete_program():
    selected_category = category_listbox.get(tk.ACTIVE)
    selected_index = program_listbox.curselection()
    if selected_category and selected_index:
        del config[selected_category][selected_index[0]]
        save_config(config)
        update_list()

def launch_program():
    selected_category = category_listbox.get(tk.ACTIVE)
    selected_index = program_listbox.curselection()
    if selected_category and selected_index:
        os.startfile(config[selected_category][selected_index[0]])

def update_list():
    category_listbox.delete(0, tk.END)
    for category in config:
        category_listbox.insert(tk.END, category)
    program_listbox.delete(0, tk.END)

def show_programs(event):
    program_listbox.delete(0, tk.END)
    selected = category_listbox.get(tk.ACTIVE)
    if selected:
        for prog in config[selected]:
            program_listbox.insert(tk.END, os.path.basename(prog))

config = load_config()

root = tk.Tk()
root.title("App Launcher")

frame = tk.Frame(root)
frame.pack(pady=10)

category_listbox = tk.Listbox(frame, width=30, height=10)
category_listbox.pack(side=tk.LEFT, padx=5)
category_listbox.bind("<<ListboxSelect>>", show_programs)

program_listbox = tk.Listbox(frame, width=50, height=10)
program_listbox.pack(side=tk.LEFT, padx=5)

btn_frame = tk.Frame(root)
btn_frame.pack()

tk.Button(btn_frame, text="Agregar Categoría", command=add_category).pack(side=tk.LEFT)
tk.Button(btn_frame, text="Eliminar Categoría", command=delete_category).pack(side=tk.LEFT)
tk.Button(btn_frame, text="Agregar Programa", command=add_program).pack(side=tk.LEFT)
tk.Button(btn_frame, text="Eliminar Programa", command=delete_program).pack(side=tk.LEFT)
tk.Button(btn_frame, text="Ejecutar", command=launch_program).pack(side=tk.LEFT)

update_list()
root.mainloop()
