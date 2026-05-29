import os

EXCLUDE_DIRS = {'.git', '.vs', 'bin', 'obj', 'Debug', 'Release', 'node_modules', 'packages'}
EXTENSIONS = {'.cs', '.sql'}
ROOT = os.path.dirname(os.path.abspath(__file__))
OUTPUT = os.path.join(ROOT, 'project_sources.txt')

with open(OUTPUT, 'w', encoding='utf-8') as out:
    for dirpath, dirnames, filenames in os.walk(ROOT):
        dirnames[:] = [d for d in dirnames if d not in EXCLUDE_DIRS]
        for f in sorted(filenames):
            if os.path.splitext(f)[1].lower() in EXTENSIONS:
                filepath = os.path.join(dirpath, f)
                relpath = os.path.relpath(filepath, ROOT)
                out.write(f'// ===== {relpath} =====\n')
                with open(filepath, 'r', encoding='utf-8', errors='replace') as src:
                    out.write(src.read())
                out.write('\n\n')

print(f'Done: {OUTPUT}')
