import sys
import os
import re


f = None
StartPath = ''
ExceptNames = ["index.md", "contents.md", "images"]
Depth = 1


def NormalizePath(path):
    path = path.replace(' ', '%20')
    path = path.replace('\\', '/')
    return path


def TrimPath(path):
    path = re.sub(r'^\d+\.', '', path)
    path = re.sub(r'\.md$', '', path)
    return path


# 深度优先遍历目录，os.walk好像是广度优先，os.listdir按字母排序所以后面先分类成文件列表和文件夹列表再递归
def FindFolderAndFile(subpath):
    global f, Depth
    fileList = []
    pathList = []
    for p in os.listdir(subpath):
        if p not in ExceptNames:
            spp = os.path.join(subpath, p)
            if os.path.isdir(spp):
                pathList.append(p)
            elif os.path.isfile(spp):
                fileList.append(p)
    for fp in fileList:
        spp = os.path.join(subpath, fp)
        f.write('{0}- [{1}](.{2})\n'.format('    ' * (Depth - 1), TrimPath(fp), NormalizePath(spp.replace(StartPath, ''))))
    for pp in pathList:
        spp = os.path.join(subpath, pp)
        f.write('<br></br>\n\n{0}- {1} {2}\n'.format('    ' * (Depth - 1), '#' * (Depth + 1), TrimPath(pp)))
        Depth += 1
        FindFolderAndFile(spp)
        Depth -= 1


def main():
    global StartPath, f
    StartPath = os.path.abspath(os.path.join(sys.path[0], '../../src'))
    contents = StartPath + '/contents.md'
    if os.path.exists(contents):
        os.remove(contents)
    f = open(contents, 'w', encoding='utf8')
    f.write('# 目录\n\n')
    FindFolderAndFile(StartPath)
    f.close()


if __name__ == "__main__":
    main()


